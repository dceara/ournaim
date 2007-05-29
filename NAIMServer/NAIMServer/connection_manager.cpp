#include "connection_manager.h"
#include "client.h"
#include "protocol.h"
#include "utils.h"

#include <winsock.h>

#include <string>

using namespace std;

void test() {
    ConnectionManager cMan = ConnectionManager();

    const string * mystr = cMan.getStatus(3);

}


/*
 *	ConnectionManager
 */

const timeval ConnectionManager::DEFAULT_SELECT_TIMEOUT = {0, 10000};

ConnectionManager::ConnectionManager() {
    onlineClientsNo = 0;
    queryExecuter = QueryExecuter();
    protocol = Protocol();
    
    onlineClients = map< int, string >();
    socketClients = map< int, Client * >();
    socketProtocols = map< int, Protocol >();
    clientsSet = set< Client * >();
    
}

ConnectionManager::~ConnectionManager() {
    for (set< Client * >::iterator it = clientsSet.begin(); it != clientsSet.end(); ++it) {
        if (*it != NULL) {
            delete *it;
        }
    }
}

bool ConnectionManager::isOnline(int clientID) {
    return false;
}

const string * ConnectionManager::getStatus(int clientID) {
    return NULL;
}

int ConnectionManager::setStatus(int clientID, string status) {
    return 0;
}

const sockaddr_in * ConnectionManager::getClientAddress(int clientID) {
    return NULL;
}

int ConnectionManager::clientConnect(int clientID, std::string status, sockaddr_in address) {
    return 0;
}

int ConnectionManager::clientDisconnect(int clientID, Client * clientMan) {
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
    return 0;
}

/*
 *	Is called when a connection is closed or timeouts
 */
int ConnectionManager::closeConnection(int sock_fd) {
    CLOSE(sock_fd);
    socketClients[sock_fd]->addInputPacket(protocol.createCONNECTION_CLOSED());
    FD_CLR(sock_fd, &read_fds);
    FD_CLR(sock_fd, &write_fds);
    return 0;
}

/*
 *	Reads a packet from the socket and dispatches it to the corresponding Client
 */
int ConnectionManager::readClientInput(int sock_fd) {
    NAIMpacket * packet;
    int n = socketProtocols[sock_fd].readPacket(sock_fd, packet);
    if (n == 0) {
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
        delete packet;
        return -1;
    }
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
 *	Initializes connection variables and runs the main loop
 */ 

int ConnectionManager::run() {

#ifdef WIN32
    WSADATA wsaData;
    WSAStartup(0x0101, &wsaData);		
#endif
    
    fd_set tmp_read_fds;	    // fd_set used temporary to preserve read_fds
    fd_set tmp_write_fds;	    // fd_set used temporary to preserve read_fds

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
    serv_addr.sin_port = htons(portno);

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

    int newsockfd;
    // main loop    
    for(;;) {
        tmp_read_fds = read_fds; 
        tmp_write_fds = write_fds;

        if (select(fdmax + 1, &tmp_read_fds, &tmp_write_fds, NULL, &DEFAULT_SELECT_TIMEOUT) == -1) {
            printf("ERROR in select: %d", errno);
            CLOSE(listen_sockfd);
            return -1;
        }

        /*
         *	Reads packets and dispatches them to the corresponding client
         */

        for(int i = 0; i <= fdmax; i++) {
            if (FD_ISSET(i, &tmp_read_fds)) {
                if (i == listen_sockfd) {
                    // new connection was detected
                    sockaddr_in cli_addr;
                    int clilen = (int)sizeof(cli_addr);
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
    }

    CLOSE(newsockfd);

    return 0;
}

