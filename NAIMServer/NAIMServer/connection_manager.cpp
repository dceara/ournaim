#include "connection_manager.h"
#include "client.h"
#include "protocol.h"
#include "utils.h"

#ifdef WIN32
#include <winsock.h>
#include <io.h>
#else
#include <errno.h>
#include <netinet/ip.h>
#include <arpa/inet.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <unistd.h>
#endif

#include <pthread.h>
#include <string>

using namespace std;

/*
 *	ConnectionManager
 */

const timeval ConnectionManager::DEFAULT_SELECT_TIMEOUT = {0, 10000};

ConnectionManager::ConnectionManager() {
    onlineClientsNo = 0;
    queryExecuter = QueryExecuter();
    protocol = Protocol();
    
    onlineClients = map< string, string >();
    socketClients = map< int, Client * >();
    clientClients = map< string, Client * >();
    socketProtocols = map< int, Protocol >();
    clientsSet = set< Client * >();

    quiting = false;
}

ConnectionManager::~ConnectionManager() {
    for (set< Client * >::iterator it = clientsSet.begin(); it != clientsSet.end(); ++it) {
        if (*it != NULL) {
            delete *it;
        }
    }
}

bool ConnectionManager::isOnline(const string * client) {
    if (onlineClients.count(*client) > 0)
        return true;
    else
        return false;
}

const string * ConnectionManager::getStatus(const string * client) {
    return &onlineClients[*client];
}

int ConnectionManager::setStatus(const string * client, const string * status) {
    onlineClients[*client] = *status;
    return 0;
}

int ConnectionManager::clientConnect(Client * clientMan, const string * client, const string * status) {
    onlineClients.insert(pair< string, string >(*client, *status));
    clientClients.insert(pair< string, Client * >(*client, clientMan));
    return 0;
}

int ConnectionManager::clientDisconnect(Client * clientMan, const string * client) {
    onlineClients.erase(*client);
    clientClients.erase(*client);
    clientsSet.erase(clientMan);
    return 0;
}

/*
 *	Is called when a new connection is created. Creates a new Client to monitor the connection.
 */
int ConnectionManager::newConnection(int sock_fd) {
    FD_SET(sock_fd, &read_fds);
    FD_SET(sock_fd, &write_fds);
    if (sock_fd > fdmax)
        fdmax = sock_fd;
    
    Client * client = new Peer(this);
    clientsSet.insert(client);
    socketClients.insert(pair< int, Client * >(sock_fd, client));
    socketProtocols.insert(pair< int, Protocol >(sock_fd, Protocol()));
    return 0;
}

/*
 *	Is called when a connection is closed or timeouts.
 */
int ConnectionManager::closeConnection(int sock_fd) {
    printf("Closing connection on socket: %d\n", sock_fd);
    CLOSE(sock_fd);
    socketClients[sock_fd]->addInputPacket(protocol.createCONNECTION_CLOSED());
    socketClients.erase(sock_fd);
    socketProtocols.erase(sock_fd);
    FD_CLR(sock_fd, &read_fds);
    FD_CLR(sock_fd, &tmp_read_fds);
    FD_CLR(sock_fd, &write_fds);
    FD_CLR(sock_fd, &tmp_write_fds);
    return 0;
}

/*
 *	Reads a packet from the socket and dispatches it to the corresponding Client
 */
int ConnectionManager::readClientInput(int sock_fd) {
    NAIMpacket * packet;
    int n = socketProtocols[sock_fd].readPacket(sock_fd, packet);
    if (n == 0) {
#ifdef WIN32
        int err = WSAGetLastError();
#endif
        closeConnection(sock_fd);
        return -1;
    }

    if (packet != NULL) {
        socketClients[sock_fd]->addInputPacket(packet);
    }

    return 0;
}

/*
 *	Writes a packet from a Clients output to the socket
 */
int ConnectionManager::writeClientOutput(int sock_fd) {
    NAIMpacket * packet = socketClients[sock_fd]->getOutputPacket();        // DELETE
    if (packet == NULL) {
        return 0;
    }

    char * buffer;                                                          // DELETE
    int length;
    if (protocol.packetToBuffer(packet, buffer, length) == NULL) {          // buffer and length are references
        // don't know if i should do something else
        delete packet->data;
        delete packet;
        return -1;
    }
    delete packet->data;
    delete packet;

    // TODO: add a timeout. the packet should not be removed from the queue if send fails.
    int n = send(sock_fd, buffer, length, 0);
    if (n != length) {
        printf("ERROR writing packet to socket: %d", sock_fd);
        delete buffer;
        return -1;
    }
    delete buffer;

    return 0;
}

/*
 *	Sends a packet from sender to receiver by transferring it to the receivers output queue
 */
int ConnectionManager::transfferPacket(const string * receiver, NAIMpacket * packet) {
    clientClients[*receiver]->addOutputPacket(packet);
    return 0;
}

/*
 *	Runs a tread for listening on the console. It uses a socket to communicate.
 */
void * commandThread(void *) {

    int com_sock = socket(AF_INET, SOCK_STREAM, 0);
    sockaddr_in serv_addr;

    memset((char *) &serv_addr, 0, sizeof(serv_addr));
    serv_addr.sin_family = AF_INET;
    serv_addr.sin_addr.s_addr = inet_addr("127.0.0.1");	                    // uses localhost ip
    serv_addr.sin_port = htons(ConnectionManager::PORTNO);

    if (connect(com_sock,(struct sockaddr*) &serv_addr,sizeof(serv_addr)) < 0) {
        printf("ERROR on creating socket for console communication");
        return NULL;
    }
        
    char buffer[256];
    while(1) {
        memset(buffer, 0, 256);
        fgets(buffer, 255, stdin);
        if (strncmp("terminate", buffer, 9) == 0) {
            NAIMpacket * packet = Protocol::createCOMMAND("terminate", 9);
            char * buffer;
            int length;
            Protocol::packetToBuffer(packet, buffer, length);
            length = send(com_sock, buffer, length, 0);
            
            delete packet->data;
            delete packet;
            delete buffer;
            break;
        }
    }

    return NULL;
}

void ConnectionManager::CreateCommandThread() {
    pthread_t thread;
    pthread_create(&thread, NULL, &commandThread, NULL);
}


/*
 *	Initializes connection variables and runs the main loop
 */ 

int ConnectionManager::run() {

#ifdef WIN32
    WSADATA wsaData;
    WSAStartup(0x0101, &wsaData);		
#endif

    // read_fds and tmp_fds are zeroed
    FD_ZERO(&read_fds);
    FD_ZERO(&tmp_read_fds);

    FD_ZERO(&write_fds);
    FD_ZERO(&tmp_write_fds);

    int listen_sockfd = socket(AF_INET, SOCK_STREAM, 0);
    if (listen_sockfd < 0) {
        printf("ERROR: Could not open a socket for listening.");
        return -1;
    }

    sockaddr_in serv_addr;
    memset((char *) &serv_addr, 0, sizeof(serv_addr));
    serv_addr.sin_family = AF_INET;
    serv_addr.sin_addr.s_addr = INADDR_ANY;	                    // uses localhost ip
    serv_addr.sin_port = htons(PORTNO);

    if (bind(listen_sockfd, (struct sockaddr *) &serv_addr, sizeof(struct sockaddr)) < 0) {
        printf("ERROR on binding: %d", errno);
        CLOSE(listen_sockfd);
        return -1;
    }

    if (listen(listen_sockfd, MAX_CLIENTS) < 0) {
        printf("ERROR on listen: %d", errno);
        CLOSE(listen_sockfd);
        return -1;
    }

    // the socket for listening is added to the monitored list
    FD_SET(listen_sockfd, &read_fds);
    fdmax = listen_sockfd;

    
    // Starts the thread that listens to the console
    CreateCommandThread();


    sockaddr_in cli_addr;
#ifdef WIN32
    int clilen = (int)sizeof(cli_addr);
#else
    unsigned int clilen = (int)sizeof(cli_addr);
#endif

    // accept the connection from the console monitoring thread

    int console_sockfd = socket(AF_INET, SOCK_STREAM, 0);
    if ((console_sockfd = accept(listen_sockfd, (struct sockaddr *)&cli_addr, &clilen)) == -1) {
        printf("ERROR, could not establish communication with the console\n");
        CLOSE(console_sockfd);
    }
    else {
        FD_SET(console_sockfd, &read_fds);
        if (console_sockfd > fdmax)
            fdmax = console_sockfd;

        Client * console = new Console(this);
        clientsSet.insert(console);
        socketClients.insert(pair< int, Client * >(console_sockfd, console));
        socketProtocols.insert(pair< int, Protocol >(console_sockfd, Protocol()));
    }



    int newsockfd;
    timeval timeout = DEFAULT_SELECT_TIMEOUT;
    // main loop    
    for(;;) {
        tmp_read_fds = read_fds; 
        tmp_write_fds = write_fds;

        if (select(fdmax + 1, &tmp_read_fds, &tmp_write_fds, NULL, &timeout) == -1) {
            printf("ERROR in select: %d", errno);
            CLOSE(listen_sockfd);
            return -1;
        }

        /*
         *	Reads packets and dispatches them to the corresponding client.
         */

        for(int i = 0; i <= fdmax; i++) {
            if (FD_ISSET(i, &tmp_read_fds)) {
                if (i == listen_sockfd) {
                    // new connection was detected
                    if ((newsockfd = accept(listen_sockfd, (struct sockaddr *)&cli_addr, &clilen)) == -1) {
                        printf("ERROR on accept: %d", errno);
                    } else {
                        printf("Server: new connection from %s\n ", inet_ntoa(cli_addr.sin_addr));

                        if (newConnection(newsockfd) < 0)  {
                            printf("ERROR on initializing connection on socket: %d", newsockfd);
                            CLOSE(newsockfd);
                        }
                    }
                }
                else {
                    readClientInput(i);
                }
            }
        }

        /*
         *	Processes packets from the clients.
         */

        for (set< Client * >::iterator it = clientsSet.begin(); it != clientsSet.end(); ++it) {
            (*it)->processPacket();
        }

        /*
         *	Writes packets from the clients.
         */

        for(int i = 0; i <= fdmax; i++) {
            if (FD_ISSET(i, &tmp_write_fds)) {
                writeClientOutput(i);
            }
        }
    
        if (quiting) {
            terminate();
            return 0;
        }
    }

    CLOSE(newsockfd);

    return 0;
}

void ConnectionManager::terminate() {
#ifdef WIN32
    WSACleanup();
#else
    for (map< int, Client * >::iterator it = socketClients.begin(); it != socketClients.end(); ++it) {
        CLOSE(it->first);
    }
#endif
}

void ConnectionManager::quit() {
    quiting = true;
}
