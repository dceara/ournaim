#include "protocol.h"

#include <winsock.h>

#include <cstdlib>

using namespace std;

const char * NAIMpacket::header = "NAIM";

Protocol::Protocol() {
    tempPacket = NULL;
}

Protocol::~Protocol() {

}

char * Protocol::packetToBuffer(NAIMpacket * packet, char * & buffer, int & bufferLength) {
    return NULL;
}

int Protocol::readPacket(int socket, NAIMpacket * & packet) {
    // TODO: better reading. now i asume all will go perfectly. add timeout for read.
    // remove hard coding
    
    // tries first to read the whole header (identifier, service, data length)
    if (readHeaderSize != HEADER_LENGTH) {
        int n = recv(socket, header + readHeaderSize, HEADER_LENGTH - readHeaderSize, 0);
        if (n <= 0) {
            packet = NULL;
            return n;
        }
        readHeaderSize += n;
    }
    
    // if the header has been read, create a new packet
    if (readHeaderSize == HEADER_LENGTH && tempPacket == NULL) {
        tempPacket = new NAIMpacket();
        tempPacket->service = ntohs(*(unsigned short *)(header + 4));
        tempPacket->dataSize = ntohs(*(unsigned short *)(header + 6));
    }

    // if the packet has been created but the data has not been read completely, read the remaining data
    if (tempPacket != NULL && readDataSize != tempPacket->dataSize) {
        int n = recv(socket, tempPacket->data + readDataSize, tempPacket->dataSize, 0);
        if (n <= 0) {
            packet = NULL;
            return n;
        }
        readDataSize += n;
    }

    // if all the data has been read reset internal variables and return packet
    if (readDataSize == packet->dataSize) {
        readHeaderSize = 0;
        readDataSize = 0;
        packet = tempPacket;
        tempPacket = NULL;
    }

    packet = NULL;
    return readHeaderSize + readDataSize;
}

NAIMpacket * Protocol::createACK() {
    NAIMpacket * temp = new NAIMpacket();
    temp->service = ACK;
    temp->dataSize = 0;
    temp->data = NULL;

    return temp;
}

NAIMpacket * Protocol::createCONNECTION_CLOSED() {
    NAIMpacket * temp = new NAIMpacket();
    temp->service = CONNECTION_CLOSED;
    temp->dataSize = 0;
    temp->data = NULL;

    return temp;
}