#include "connection_manager.h"
#include "client.h"
#include "protocol.h"

#include <string>

using namespace std;

void test() {
    ConnectionManager cMan = ConnectionManager();

    const string * mystr = cMan.getStatus(3);
    
}


/*
 *	ConnectionManager
 */

ConnectionManager::ConnectionManager() {

}

ConnectionManager::~ConnectionManager() {

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

int ConnectionManager::run() {
    return 0;
}

