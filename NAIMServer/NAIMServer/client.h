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
    std::queue< NAIMpacket * > inputQueue;       // input packet queue
    std::queue< NAIMpacket * > outputQueue;      // output packet queue
public:
    Client(ConnectionManager * parent);
    ~Client();

    /*
     *	Adds a packet in the input queue of the client. The packet will be deleted after being processed so
     *  DO NOT delete it externally :P
     */
    virtual int addInputPacket(NAIMpacket * packet);

    /*
     *	Gets a packet from the input queue. After processing the memory should be freed.
     */
    virtual NAIMpacket * getOutputPacket();

    /*
     *	Processes a packet from the input queue. It does not process all the packets to maintain asynchronous
     *  operation.
     */
    virtual int processPacket();
};

/*
 *	Handles communication with the console.
 */
class Console : Client {
public:
    Console(ConnectionManager * parent) : Client(parent) {};

    /* Override */
    int processPacket();
};

/*
 *	Handles communication with a peer.
 */
class Peer : Client {
    int clientID;                       // the database id of the client it handles. the name might also be needed
    time_t lastActiveTime;              // the time the client was last active.
public:
    Peer(ConnectionManager * parent, int clientID, time_t lastActiveTime);
    ~Peer();

    /* Override */
    int processPacket();

    /*
     *	Pings the client. Should be called before the packets in the output queue are processed.
     */
    int ping();
};

#endif  /* CLIENT_H */

