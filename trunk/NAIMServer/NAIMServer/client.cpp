#include "client.h"
#include "connection_manager.h"
#include "protocol.h"

#include <cstring>
#include <ctime>

using namespace std;

/*
 *	Client
 */

Client::Client(ConnectionManager * parent) {
    cMan = parent;
    inputQueue = queue< NAIMpacket * >();
    outputQueue = queue< NAIMpacket * >();
    
    protocol = Protocol();
}

Client::~Client() {

}

int Client::addInputPacket(NAIMpacket * packet) {
    inputQueue.push(packet);
    return 0;
}

/*
 *	Adds a packet to the output queue of the client. The packet will be deleted after being processed so
 *  DO NOT delete it externally :P
 */
int Client::addOutputPacket(NAIMpacket * packet) {
    outputQueue.push(packet);
    return 0;
}

/*
 *	Returns the first packet in the output queue and removes it.
 *  TODO: this should not remove the packet because it might not have been sent
 */
NAIMpacket * Client::getOutputPacket() {
    NAIMpacket * tempPacket = NULL;
    if (outputQueue.size() > 0) {
        tempPacket = outputQueue.front();
        outputQueue.pop();
    }
    return tempPacket;
}

int Client::processPacket() {
    return 0;
}




/*
 *	Console
 */

int Console::processPacket() {
    if (inputQueue.size() > 0) {
        NAIMpacket * packet = inputQueue.front();
        inputQueue.pop();

        if (strncmp(packet->data, "terminate", 9) == 0) {
            cMan->quit();
        }

        delete packet->data;
        delete packet;
    }

    return 0;
}




/*
 *	Peer
 */

Peer::Peer(ConnectionManager * parent) : Client(parent) {
    outputQueue.push(protocol.createACK());
    clientName = NULL;
}

Peer::~Peer() {
    if (clientName != NULL) {
        delete clientName;
    }
}

/*
 *	SIGN_UP
 */
int Peer::processSIGN_UP(NAIMpacket * packet) {
    char * username, * password;
    Protocol::getSIGN_UPUsername(packet, username);
    if (cMan->queryExecuter.isClient(username)) {
        NAIMpacket * packet = Protocol::createNACK();
        addOutputPacket(packet);
    }
    else {
        // TODO: Send contacts list. Check if there is no client already logged in on this socket
        Protocol::getSIGN_UPPassword(packet, password);

        cMan->queryExecuter.addClient(username, password);
        cMan->queryExecuter.addGroup("Friends", username);
        delete password;

        clientName = new char[strlen(username) + 1];
        strcpy(clientName, username);
        cMan->clientConnect(this, username, AVAILABLE);        

        NAIMpacket * packet = Protocol::createACK();
        addOutputPacket(packet);
    }

    delete username;
    delete packet->data;
    delete packet;
    return 0;
}

/*
 *	LOGIN
 */
int Peer::processLOGIN(NAIMpacket * packet) {
    return 0;
}

/*
 *	TEXT
 */
int Peer::processTEXT(NAIMpacket * packet) {
    // TODO: check the sender
    char * receiver;
    Protocol::getTEXTReceiver(packet, receiver);

    cMan->transferPacket(receiver, packet);

    delete receiver;
    return 0;
}

/*
 *	CONNECTION_REQ
 */
int Peer::processCONNECTION_REQ(NAIMpacket * packet) {
    return 0;
}

/*
 *	CONNECTION_DATA
 */
int Peer::processCONNECTIONDATA(NAIMpacket * packet) {
    return 0;
}

int Peer::processPacket() {
    if (inputQueue.size() > 0) {
        NAIMpacket * packet = inputQueue.front();

        printf("Packet received: \n");
        printf("Service: %d\n", packet->service);
        printf("Data: ");
        for (int i = 0; i < packet->dataSize; ++i)
            printf("%c", packet->data[i]);
        printf("\n");


        switch(packet->service) {
            // PING
            case 2: {
                time(&lastActiveTime);
                break;
                    }
            case 3: {
                time(&lastActiveTime);
                processSIGN_UP(packet);
                break;
                    }
            case 4: {
                time(&lastActiveTime);
                processLOGIN(packet);
                break;
                    }
            case 6: {
                time(&lastActiveTime);
                processTEXT(packet);
                break;
                    }
            case 10: {
                time(&lastActiveTime);
                processCONNECTION_REQ(packet);
                break;
                    }
            case 11: {
                time(&lastActiveTime);
                processCONNECTIONDATA(packet);
                break;
                    }
        }

        inputQueue.pop();
    } 
    return 0;
}

int Peer::ping() {
    return 0;
}
