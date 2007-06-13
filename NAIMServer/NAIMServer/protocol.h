#ifndef PROTOCOL_H
#define PROTOCOL_H

/* Structure used to store a NAIM packet */

struct NAIMpacket {
    static const char * header;
    unsigned short service;
    unsigned short dataSize;
    char * data;
};

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
    ADD_CONTACT         = 16,
    REMOVE_CONTACT      = 17,
    STATUS              = 18,
    DISCONNECT          = 19,
    REMOVE_GROUP        = 20,

    // internal
    
    CONNECTION_CLOSED   = 64,
    COMMAND             = 65,
};

/* Enumeration of the errors used by the NAIM protocol */

enum Errors {

};

/*
 *	Special statuses.
 */
const char AVAILABLE[]  = "Available";
const char INVISIBLE[]  = "Invisible";

/* Class that contains functions specific to the NAIM protocol */

class Protocol {
    const static unsigned short HEADER_LENGTH = 8;
    char header[16];
    NAIMpacket * tempPacket;                // the packet that will be returned.
    unsigned short readHeaderSize;          // the size of the part of the header already read.
    unsigned short readDataSize;            // the size of the data currently read.
public:
    Protocol();
    ~Protocol();
    
    /* 
     * Packs the data from packet in a contiguous buffer that can be sent through a TCP connection. The buffer is 
     * allocated dynamically so it should be deleted after use.
     */
    static char * packetToBuffer(NAIMpacket * packet, char * & buffer, int & bufferLength);
    /*
     * Reads and returns the first NAIM packet from the TCP connection. The data ahead of the packet is discarded.
     * The packet is allocated dynamically and should be deleted after use.
     */
    int readPacket(int socket, NAIMpacket * & packet);

    /*
     *	Functions for creating packets.
     */

    static NAIMpacket * createACK();

    static NAIMpacket * createNACK();

    static NAIMpacket * createPING();

    static NAIMpacket * createUSER_CONNECTED(const char * username, const char * status);

    static NAIMpacket * createUSER_DISCONNECTED(const char * username);

    static NAIMpacket * createSTATUS(const char * username, const char * status);

    static NAIMpacket * createUSER_LIST(const char * data, unsigned short length);

    static NAIMpacket * createCOMMAND(const char * command, unsigned short length);

    static NAIMpacket * createCONNECTION_CLOSED();

    static NAIMpacket * createDISCONNECT();    

    /*
     *	Functions for processing packets.
     */

    /*
     *	Returns the username from a SIGN_UP packet.
     */
    static char * getSIGN_UPUsername(NAIMpacket * packetSIGN_UP, char * & username);
    /*
     *	Returns the password from a SIGN_UP packet.
     */
    static char * getSIGN_UPPassword(NAIMpacket * packetSIGN_UP, char * & password);
    /*
     *	Returns the username from a LOGIN packet.
     */
    static char * getLOGINUsername(NAIMpacket * packetLOGIN, char * & username);
    /*
     *	Returns the password from a LOGIN packet.
     */
    static char * getLOGINPassword(NAIMpacket * packetLOGIN, char * & password);
    /*
     *	Returns the status from a LOGIN packet.
     */
    static char * getLOGINStatus(NAIMpacket * packetLOGIN, char * & status);
    /*
     *	Returns the sender from a TEXT packet.
     */
    static char * getTEXTSender(NAIMpacket * packetTEXT, char * & sender);
    /*
     *	Returns the receiver from a TEXT packet.
     */
    static char * getTEXTReceiver(NAIMpacket * packetTEXT, char * & receiver);
    /*
     *	Returns the sender from a CONNECTION_REQ packet.
     */
    static char * getCONNECTION_REQSender(NAIMpacket * packetCONNECTION_REQ, char * & sender);
    /*
     *	Returns the receiver from a CONNECTION_DATA packet.
     */
    static char * getCONNECTION_REQReceiver(NAIMpacket * packetCONNECTION_REQ, char * & receiver);
    /*
     *	Returns the sender from a CONNECTION_REQ packet.
     */
    static char * getCONNECTION_DATASender(NAIMpacket * packetCONNECTION_DATA, char * & sender);
    /*
     *	Returns the receiver from a CONNECTION_DATA packet.
     */
    static char * getCONNECTION_DATAReceiver(NAIMpacket * packetCONNECTION_DATA, char * & receiver);
    /*
     *	Returns the username from a ADD_CONTACT package;
     */
    static char * getADD_CONTACTUsername(NAIMpacket * packetADD_CONTACT, char * & username);
    /*
     *	Returns the new contact from a ADD_CONTACT package;
     */
    static char * getADD_CONTACTContact(NAIMpacket * packetADD_CONTACT, char * & contact);
    /*
     *	Returns the group from a ADD_CONTACT package;
     */
    static char * getADD_CONTACTGroup(NAIMpacket * packetADD_CONTACT, char * & group);
    /*
     *	Returns the username from a REMOVE_CONTACT package;
     */
    static char * getREMOVE_CONTACTUsername(NAIMpacket * packetREMOVE_CONTACT, char * & username);
    /*
     *	Returns the new contact from a REMOVE_CONTACT package;
     */
    static char * getREMOVE_CONTACTContact(NAIMpacket * packetREMOVE_CONTACT, char * & contact);
    /*
     *	Returns the username from a STATUS package;
     */
    static char * getSTATUSUsername(NAIMpacket * packetSTATUS, char * & username);
    /*
     *	Returns the status from a STATUS package;
     */
    static char * getSTATUSStatus(NAIMpacket * packetSTATUS, char * & status);
    /*
     *	Returns the client from a REMOVE_GROUP packet;
     */
    static char * getREMOVE_GROUPClient(NAIMpacket * packetREMOVE_GROUP, char * & client);
    /*
    *	Returns the group from a REMOVE_GROUP packet;
    */
    static char * getREMOVE_GROUPGroup(NAIMpacket * packetREMOVE_GROUP, char * & group);
};

#endif  /* PROTOCOL_H */

