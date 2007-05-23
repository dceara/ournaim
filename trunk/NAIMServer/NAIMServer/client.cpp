#include "client.h"
#include "connection_manager.h"
#include "protocol.h"

using namespace std;

/*
 *	Client
 */

Client::Client(ConnectionManager * parent) {

}

Client::~Client() {

}

int Client::addInputPacket(NAIMpacket * packet) {
    return 0;
}

NAIMpacket * Client::getOutputPacket() {
    return NULL;
}

int Client::processPacket() {
    return 0;
}




/*
 *	Console
 */

int Console::processPacket() {
    return 0;
}




/*
 *	Peer
 */

Peer::Peer(ConnectionManager * parent, int clientID, time_t lastActiveTime) : Client(parent) {

}

Peer::~Peer() {

}

int Peer::processPacket() {
    return 0;
}

int Peer::ping() {
    return 0;
}