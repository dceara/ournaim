#include "protocol.h"
#include "utils.h"

#ifdef WIN32
#include <winsock.h>
#else
#include <sys/socket.h>
#include <sys/types.h>
#include <arpa/inet.h>
#endif

#include <cstdlib>
#include <cstring>

using namespace std;

const char * NAIMpacket::header = "NAIM";

Protocol::Protocol() {
    tempPacket = NULL;
    readHeaderSize = 0;
    readDataSize = 0;
}

Protocol::~Protocol() {

}

char * Protocol::packetToBuffer(NAIMpacket * packet, char * & buffer, int & bufferLength) {
    // TODO: find another way. this is inefficient
    // remove hard coding

    bufferLength = 8 + packet->dataSize;
    buffer = new char[bufferLength];
    memcpy(buffer, packet->header, 4);
    writeUShort(htons(packet->service), buffer + 4);
    writeUShort(htons(packet->dataSize), buffer + 6);
    memcpy(buffer + 8, packet->data, packet->dataSize);

    return buffer;
}

int Protocol::readPacket(int socket, NAIMpacket * & packet) {
    packet = NULL;
    
    // TODO: better reading. now i asume all will go perfectly. add timeout for read.
    // remove hard coding
    
    // tries first to read the whole header (identifier, service, data length)
    if (readHeaderSize != HEADER_LENGTH) {
        int n = recv(socket, header + readHeaderSize, HEADER_LENGTH - readHeaderSize, 0);
        if (n <= 0) {
            return n;
        }
        readHeaderSize += n;
    }
    
    // if the header has been read, create a new packet
    if (readHeaderSize == HEADER_LENGTH && tempPacket == NULL) {
        tempPacket = new NAIMpacket();
        tempPacket->service = ntohs(readUShort(header + 4));
        tempPacket->dataSize = ntohs(readUShort(header + 6));
        tempPacket->data = new char[tempPacket->dataSize];
    }

    // if the packet has been created but the data has not been read completely, read the remaining data
    if (tempPacket != NULL && readDataSize != tempPacket->dataSize) {
        int n = recv(socket, tempPacket->data + readDataSize, tempPacket->dataSize, 0);
        if (n <= 0) {
            delete packet->data;
            delete packet;
            return n;
        }
        readDataSize += n;
    }

    // if all the data has been read reset internal variables and return packet
    if (readDataSize == tempPacket->dataSize) {
        readHeaderSize = 0;
        readDataSize = 0;
        packet = tempPacket;
        tempPacket = NULL;
    }

    return 1;
}

NAIMpacket * Protocol::createACK() {
    NAIMpacket * temp = new NAIMpacket();
    temp->service = ACK;
    temp->dataSize = 0;
    temp->data = NULL;

    return temp;
}

NAIMpacket * Protocol::createCOMMAND(const char * command, unsigned int length) {
    NAIMpacket * temp = new NAIMpacket();
    temp->service = CONNECTION_CLOSED;
    temp->dataSize = length;
    temp->data = new char[length];
    memcpy(temp->data, command, length);

    return temp;
}

NAIMpacket * Protocol::createCONNECTION_CLOSED() {
    NAIMpacket * temp = new NAIMpacket();
    temp->service = CONNECTION_CLOSED;
    temp->dataSize = 0;
    temp->data = NULL;

    return temp;
}

// TODO: check packet integrity :P

/*
 *	Returns the username from a SIGN_UP packet. Returns a pointer into the packet data.
 */
char * Protocol::getSIGN_UPUsername(NAIMpacket * packetSIGN_UP, char * & username, unsigned short & length) {
    username = packetSIGN_UP->data + sizeof(short);
    length = readUShort(packetSIGN_UP->data);
    return username;
}
/*
 *	Returns the password from a SIGN_UP packet.
 */
char * Protocol::getSIGN_UPPassword(NAIMpacket * packetSIGN_UP, char * & password, unsigned short & length) {
    password = packetSIGN_UP->data + 2 * sizeof(short) + readUShort(packetSIGN_UP->data);
    length = readUShort(packetSIGN_UP->data + sizeof(short) + readUShort(packetSIGN_UP->data));
    return password;
}
/*
 *	Returns the username from a LOGIN packet.
 */
char * Protocol::getLOGINUsername(NAIMpacket * packetLOGIN, char * & username, unsigned short & length) {
    username = packetLOGIN->data + sizeof(short);
    length = readUShort(packetLOGIN->data);
    return username;
}
/*
 *	Returns the password from a LOGIN packet.
 */
char * Protocol::getLOGINPPassword(NAIMpacket * packetLOGIN, char * & password, unsigned short & length) {
    password = packetLOGIN->data + 2 * sizeof(short) + readUShort(packetLOGIN->data);
    length = readUShort(packetLOGIN->data + sizeof(short) + readUShort(packetLOGIN->data));
    return password;
}
/*
 *	Returns the status from a LOGIN packet.
 */
char * Protocol::getLOGINPStatus(NAIMpacket * packetLOGIN, char * & status, unsigned short & length) {
    status = packetLOGIN->data + 3 * sizeof(short) + readUShort(packetLOGIN->data) + readUShort(packetLOGIN->data + sizeof(short) + readUShort(packetLOGIN->data));
    length = 2 * sizeof(short) + readUShort(packetLOGIN->data) + readUShort(packetLOGIN->data + sizeof(short) + readUShort(packetLOGIN->data));
    return status;
}
/*
 *	Returns the sender from a TEXT packet.
 */
char * Protocol::getTEXTSender(NAIMpacket * packetTEXT, char * & sender, unsigned short & length) {
    sender = packetTEXT->data + sizeof(short);
    length = readUShort(packetTEXT->data);
    return sender;
}
/*
 *	Returns the receiver from a TEXT packet.
 */
char * Protocol::getTEXTReceiver(NAIMpacket * packetTEXT, char * & receiver, unsigned short & length) {
    receiver = packetTEXT->data + 2 * sizeof(short) + readUShort(packetTEXT->data);
    length = readUShort(packetTEXT->data + sizeof(short) + readUShort(packetTEXT->data));
    return receiver;
}
/*
 *	Returns the sender from a CONNECTION_REQ packet.
 */
char * Protocol::getCONNECTION_REQSender(NAIMpacket * packetCONNECTION_REQ, char * & sender, unsigned short & length) {
    sender = packetCONNECTION_REQ->data + sizeof(short);
    length = readUShort(packetCONNECTION_REQ->data);
    return sender;
}
/*
 *	Returns the receiver from a CONNECTION_DATA packet.
 */
char * Protocol::getCONNECTION_REQReceiver(NAIMpacket * packetCONNECTION_REQ, char * & receiver, unsigned short & length) {
    receiver = packetCONNECTION_REQ->data + 2 * sizeof(short) + readUShort(packetCONNECTION_REQ->data);
    length = readUShort(packetCONNECTION_REQ->data + sizeof(short) + readUShort(packetCONNECTION_REQ->data));
    return receiver;
}
/*
 *	Returns the sender from a CONNECTION_REQ packet.
 */
char * Protocol::getCONNECTION_DATASender(NAIMpacket * packetCONNECTION_DATA, char * & sender, unsigned short & length) {
    sender = packetCONNECTION_DATA->data + sizeof(short);
    length = readUShort(packetCONNECTION_DATA->data);
    return sender;
}
/*
 *	Returns the receiver from a CONNECTION_DATA packet.
 */
char * Protocol::getCONNECTION_DATAReceiver(NAIMpacket * packetCONNECTION_DATA, char * & receiver, unsigned short & length) {
    receiver = packetCONNECTION_DATA->data + 2 * sizeof(short) + readUShort(packetCONNECTION_DATA->data);
    length = readUShort(packetCONNECTION_DATA->data + sizeof(short) + readUShort(packetCONNECTION_DATA->data));
    return receiver;
}
