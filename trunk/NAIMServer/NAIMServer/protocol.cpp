#include "protocol.h"

#include <cstdlib>

using namespace std;

Protocol::Protocol() {

}

Protocol::~Protocol() {

}

char * Protocol::packetToBuffer(NAIMpacket packet) {
    return NULL;
}

NAIMpacket * Protocol::readPacket(int socket) {
    return NULL;
}

