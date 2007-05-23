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

int ConnectionManager::clientDisconnect(int clientID) {
    return 0;
}

int ConnectionManager::run() {
    return 0;
}