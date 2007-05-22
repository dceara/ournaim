#ifndef PROTOCOL_H
#define PROTOCOL_H

/* Structure used to store a NAIM packet */

struct NAIMpacket {
    static const char * header;
    unsigned short service;
    unsigned short dataLength;
    char * data;
};

const char * NAIMpacket::header = "NAIM";

/* Enumeration of the services used by the NAIM protocol */

enum Services {
    ACK                 =  0,
    NACK                =  1,
    PING                =  2,
    SIGN_UP             =  3,
    LOGIN               =  4,
    LOGOUT              =  5,
    TEXT                =  6,
    USER_LIST           =  7,
    USER_CONNECTED      =  8,
    USER_DISCONNECTED   =  9,
    CONNECTION_REQ      = 10,
    CONNECTION_DATA     = 11,

    HELLO               = 12,
    FILE_TRANSFER_SEND  = 13,
    FILE_TRANSFER_GET   = 14,
    FILE_LIST           = 15,
};

/* Class that contains functions specific to the NAIM protocol */

class Protocol {
    char * inBuffer;            // internal buffer
    NAIMpacket * tempPacket;    // the packet that will be returned
    unsigned int rdLength;      // the length of the data currently read
public:
    /* 
     * Packs the data from packet in a contiguous buffer that can be sent through a TCP connection. The buffer is 
     * allocated dynamically so it should be deleted after use.
     */
    char * packetToBuffer(NAIMpacket packet);
    /*
     * Reads and returns the first NAIM packet from the TCP connection. The data ahead of the packet is discarded.
     * The packet is allocated dynamically.
     */
    NAIMpacket * readPacket(int socket);
};

#endif  /* PROTOCOL_H */