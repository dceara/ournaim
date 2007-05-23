#include "client.h"
#include "connection_manager.h"
#include "protocol.h"


/*
 *	Client
 */

Client::Client(ConnectionManager * parent) {

}

void Client::addInputPacket(NAIMpacket * packet) {

}

NAIMpacket * Client::getOutputPacket() {
    return NULL;
}

void Client::processPacket() {

}

/*
 *	Peer
 */

Peer::Peer(ConnectionManager * parent, int clientID, time_t lastActiveTime) : Client(parent) {

}

void Peer::ping() {

}