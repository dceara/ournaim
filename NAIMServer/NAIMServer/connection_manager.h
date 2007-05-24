#ifndef CONNECTION_MANAGER_H
#define CONNECTION_MANAGER_H

#include "client.h"

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
    int onlineClientsNo;                            // number of online clients.
    std::map< int, std::string > onlineClients;     // the ids and status of the online clients. dont't know if we should store ids or names.
    std::map< int, sockaddr_in > clientsAddress;    // the addresses of the clients.
    std::map< int, Client * > socketClients;        // maps each socket to a client.
    std::set< Client * > clientsMan;                // set with all the clients managers
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

