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
    /* Returns true if the client with clientID is online */
    bool isOnline(int clientID);

    /* Returns the status of the specified client */
    const std::string & getStatus(int clientID);


};

#endif  /* CONNECTION_MANAGER_H */
