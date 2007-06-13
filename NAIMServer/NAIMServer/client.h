#ifndef CLIENT_H
#define CLIENT_H

#include "connection_manager.h"
#include "protocol.h"

#include <time.h>

#include <queue>

class ConnectionManager;

/*
 *	Handles communication with a client, console or peer
 */
class Client {
protected:
    ConnectionManager * cMan;                   // reference to it's parent. this is needed to access information about
                                                // all the other clients
    Protocol protocol;                          // for protocol usage    

    std::queue< NAIMpacket * > inputQueue;      // input packet queue
    std::queue< NAIMpacket * > outputQueue;     // output packet queue

    time_t lastActiveTime;                      // the time the client was last active.
    time_t lastPingTime;
    bool disposable;
public:
    Client(ConnectionManager * parent);
    virtual ~Client();

    /*
     *	Adds a packet in the input queue of the client. The packet will be deleted after being processed so
     *  DO NOT delete it externally :P
     */
    virtual int addInputPacket(NAIMpacket * packet);

    /*
     *	Adds a packet to the output queue of the client. The packet will be deleted after being processed so
     *  DO NOT delete it externally :P
     */
    virtual int addOutputPacket(NAIMpacket * packet);

    /*
     *	Gets a packet from the output queue. After processing the memory should be freed.
     */
    virtual NAIMpacket * getOutputPacket();

    /*
     *	Processes a packet from the input queue. It does not process all the packets to maintain asynchronous
     *  operation.
     */
    virtual int processPacket();    

    /*
     *	Returns true if the client may be disposed.
     */
    virtual bool isDisposable();

    /*
     *	Disconnects the user.
     */
    virtual int disconnect(NAIMpacket * packetDISCONNECT);

    /*
     *	Returns the number of seconds since the connection was active
     */
    virtual const time_t * getLastActiveTime();

    /*
    *	Returns the number of seconds since the connection was pinged
    */
    virtual const time_t * getLastPingTime();

    /*
     *	Resets the lastActiveTime to currentTime;
     */
    virtual void resetLastActiveTime();

    /*
     *	Pings the client. Should be called before the packets in the output queue are processed.
     */
    virtual int ping();
};

/*
 *	Handles communication with the console.
 */
class Console : public Client {
public:
    Console(ConnectionManager * parent) : Client(parent) {};

    /* Override */
    int processPacket();
};

/*
 *	Handles communication with a peer.
 */
class Peer : public Client {
    int clientID;                       // the database id of the client it handles. the name might also be 
    char * clientName;                  // the name of the client that is managed. if it is NULL no client is logged in on this socket

    /*
     *	Internal functions.
     */


    
    /*
     *	Functions for processing packets.
     */

    /*
     *	SIGN_UP
     */
    int processSIGN_UP(NAIMpacket * packet);
    /*
     *	LOGIN
     */
    int processLOGIN(NAIMpacket * packet);
    /*
     *	LOGOUT
     */
    int processLOGOUT(NAIMpacket * packet);
    /*
     *	TEXT
     */
    int processTEXT(NAIMpacket * packet);
    /*
     *	CONNECTION_REQ
     */
    int processCONNECTION_REQ(NAIMpacket * packet);
    /*
     *	CONNECTION_DATA
     */
    int processCONNECTIONDATA(NAIMpacket * packet);
    /*
     *	ADD_CONTACT
     */
    int processADD_CONTACT(NAIMpacket * packet);
    /*
     *	REMOVE_CONTACT
     */
    int processREMOVE_CONTACT(NAIMpacket * packet);
    /*
     *	REMOVE_GROUP
     */
    int processREMOVE_GROUP(NAIMpacket * packet);
    /*
     *	STATUS
     */
    int processSTATUS(NAIMpacket * packet);
    /*
     *	CONNECTION_CLOSED
     */
    int processCONNECTION_CLOSED(NAIMpacket * packet);
    /*
     *	CONNECTION_CLOSED
     */
    int processDISCONNECT(NAIMpacket * packet);

public:
    Peer(ConnectionManager * parent);
    ~Peer();

    /* Override */
    int processPacket();

    /*
     *	Disconnects the user.
     */
    int disconnect(NAIMpacket * packetDISCONNECT);

    /*
     *	Returns the number of seconds since the connection was active
     */
    const time_t * getLastActiveTime();

    /*
     *	Returns the number of seconds since the connection was pinged
     */
    const time_t * getLastPingTime();

    /*
     *	Pings the client. Should be called before the packets in the output queue are processed.
     */
    int ping();
};

#endif  /* CLIENT_H */

