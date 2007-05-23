#include "connection_manager.h"
#include "client.h"
#include "protocol.h"

#include <string>

void test() {
    ConnectionManager cMan = ConnectionManager();

    const std::string * mystr = cMan.getStatus(3);
    
}


/*
 *	ConnectionManager
 */

ConnectionManager::ConnectionManager() {

}

bool ConnectionManager::isOnline(int clientID) {

}

const std::string * ConnectionManager::getStatus(int clientID) {
    
}