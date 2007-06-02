#ifndef CONNECTION_MANAGER_H
#define CONNECTION_MANAGER_H

#include "client.h"
#include "data_access.h"
#include "protocol.h"

#include <map>
#include <set>
#include <string>

#ifdef WIN32
#include <winsock.h>
#else
#include <sys/socket.h>
#include <sys/types.h>
#include <netinet/ip.h>
#endif

/*
*	Runs a tread for listening on the console. It uses a socket to communicate.
*/
void * commandThread(void *);

class Client;

class ConnectionManager {
    fd_set read_fds;	        // fd_set used to monitor sockets for write
    fd_set write_fds;	        // fd_set used to monitor sockets for write

    fd_set tmp_read_fds;	    // fd_set used temporary to preserve read_fds
    fd_set tmp_write_fds;	    // fd_set used temporary to preserve read_fds

    int fdmax;		            // the highest file descriptor that is monitored

    QueryExecuter queryExecuter;
    Protocol protocol;

    int onlineClientsNo;                                    // number of online clients.
    std::map< std::string, std::string > onlineClients;     // the ids and status of the online clients. dont't know if we should store ids or names.
    std::map< int, Client * > socketClients;                // maps each socket to a client.
    std::map< std::string, Client * > clientClients;                  // maps each client to its manager
    std::map< int, Protocol > socketProtocols;              // an instance of Protocol is needed for each client
    std::set< Client * > clientsSet;                        // set with all the clients managers

    bool quiting;                                           // if this is set to true, the server will close.

    friend class Peer;

    /*
     *	Is called when a new connection is created. Creates a new Client to monitor the connection.
     */
    int newConnection(int sock_fd);
    /*
     *	Is called when a connection is closed or timeouts.
     */
    int closeConnection(int sock_fd);
    /*
     *	Reads a packet from the socket and dispatches it to the corresponding Client.
     */
    int readClientInput(int sock_fd);
    /*
     *	Writes a packet from a Clients output to the socket.
     */
    int writeClientOutput(int sock_fd);
    /*
     *	Creates the thread for listening on the console.
     */
    void CreateCommandThread();
    /*
     *	Releases all resources and closes the server.
     */
    void terminate();

public:
    const static int PORTNO = 18005;
    const static int MAX_CLIENTS = 128;
    const static timeval DEFAULT_SELECT_TIMEOUT;

    ConnectionManager();
    ~ConnectionManager();

    /* Returns true if the client with clientID is online */
    bool isOnline(const std::string * client);

    /*
     *  Returns the status of the specified client. If the client is not online it returns NULL. If the client
     *  has no status it returns "".
     */
    const std::string * getStatus(const std::string * client);

    /* Sets the status of a client */
    int setStatus(const std::string * client, const std::string * status);

    /* Ads a client to the online list. */
    int clientConnect(Client * clientMan, const std::string * client, const std::string * status);

    /* Removes a client from the online list. Called when a client disconnects. */
    int clientDisconnect(Client * clientMan, const std::string * client);
    /*
     *	Sends a packet from sender to receiver by transferring it to the receivers output queue
     */
    int transfferPacket(const std::string * receiver, NAIMpacket * packet);

    /*
     *	Runs the main loop
     */ 
    int run();

    /*
     *	Tells the server to quit.
     */
    void quit();
};

#endif  /* CONNECTION_MANAGER_H */

