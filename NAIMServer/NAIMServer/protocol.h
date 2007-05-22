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
    ACK             =  0,
    NACK            =  1,
    LOGIN           =  2,
    LOGOUT          =  3,
    USER_CONNECTED
};

/* Class that contains functions specific to the NAIM protocol */

class Protocol {
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