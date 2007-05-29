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
#endif

class Client;

class ConnectionManager {
    const static int portno = 18005;
    const static int MAX_CLIENTS = 128;
    const static timeval DEFAULT_SELECT_TIMEOUT;

    fd_set read_fds;	        // fd_set used to monitor sockets for write
    fd_set write_fds;	        // fd_set used to monitor sockets for write

    int fdmax;		            // the highest file descriptor that is monitored

    QueryExecuter queryExecuter;
    Protocol protocol;

    int onlineClientsNo;                            // number of online clients.
    std::map< int, std::string > onlineClients;     // the ids and status of the online clients. dont't know if we should store ids or names.
    std::map< int, Client * > socketClients;        // maps each socket to a client.
    std::map< int, Protocol > socketProtocols;      // an instance of Protocol is needed for each client
    std::set< Client * > clientsSet;                // set with all the clients managers
    

    /*
     *	Is called when a new connection is created. Creates a new Client to monitor the connection.
     */
    int newConnection(int sock_fd);
    int closeConnection(int sock_fd);
    /*
     *	Reads a packet from the socket and dispatches it to the corresponding Client
     */
    int readClientInput(int sock_fd);
    /*
     *	Writes a packet from a Clients output to the socket
     */
    int writeClientOutput(int sock_fd);

public:
    ConnectionManager();
    ~ConnectionManager();

    /* Returns true if the client with clientID is online */
    bool isOnline(int clientID);

    /*
     *  Returns the status of the specified client. If the client is not online it returns NULL. If the client
     *  has no status it returns "".
     */
    const std::string * getStatus(int clientID);

    /* Sets the status of a client */
    int setStatus(int clientID, std::string status);

    /* Gets the address of the client */
    const sockaddr_in * getClientAddress(int clientID);

    /* Ads a client to the online list. */
    int clientConnect(int clientID, std::string status, sockaddr_in address);

    /* Removes a client from the online list. Called when a client disconnects. */
    int clientDisconnect(int clientID, Client * clientMan);

    /* Runs the main loop */
    int run();
};

#endif  /* CONNECTION_MANAGER_H */

