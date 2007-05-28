#include "protocol.h"

#include <cstdlib>

using namespace std;

const char * NAIMpacket::header = "NAIM";

Protocol::Protocol() {

}

Protocol::~Protocol() {

}

char * Protocol::packetToBuffer(NAIMpacket * packet, char * & buffer, int & bufferLength) {
    return NULL;
}

NAIMpacket * Protocol::readPacket(int socket) {
    return NULL;
}

NAIMpacket * Protocol::createACK() {
    NAIMpacket * temp = new NAIMpacket();
    temp->service = ACK;
    temp->dataLength = 0;
    temp->data = NULL;

    return temp;
}

NAIMpacket * Protocol::createCONNECTION_CLOSED() {
    NAIMpacket * temp = new NAIMpacket();
    temp->service = CONNECTION_CLOSED;
    temp->dataLength = 0;
    temp->data = NULL;

    return temp;
}