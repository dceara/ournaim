#ifndef CONNECTION_MANAGER_H
#define CONNECTION_MANAGER_H

#include <map>
#include <string>

#include "client.h"

class Client;

class ConnectionManager {
    int onlineClientsNo;                             // number of online clients.
    std::map< int, std::string > onlineClients;      // the ids and status of the online clients. dont't know if we should store ids or names
    std::map< int, Client > socketClients;           // maps each client to a socket
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

    /* Removes a client from the online list. Called when a client disconnects. */
    int clientDisconnect(int clientID);

    /* Runs the main loop */
    int run();
};

#endif  /* CONNECTION_MANAGER_H */
