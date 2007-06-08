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

    disposable = false;
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
 *	Returns true if the client may be disposed.
 */
bool Client::isDisposable() {
    return disposable;
}

/*
 *	Implemented by Peer
 */
int Client::disconnect(NAIMpacket * packetDISCONNECT) {
    return 0;
}
/*
 *	Implemented by Peer
 */
int Client::ping() {
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
        NAIMpacket * tempPacket = Protocol::createNACK();
        addOutputPacket(tempPacket);
    }
    else {
        Protocol::getSIGN_UPPassword(packet, password);

        cMan->queryExecuter.addClient(username, password);
        cMan->queryExecuter.addGroup("Friends", username);
        delete password;

        NAIMpacket * tempPacket = Protocol::createACK();
        addOutputPacket(tempPacket);
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
    // TODO: check if the gets do not return NULL. add error messages
    char * username, * password;

    // Check if the client exists
    Protocol::getLOGINUsername(packet, username);
    if (!cMan->queryExecuter.isClient(username)) {
        NAIMpacket * tempPacket = Protocol::createNACK();
        addOutputPacket(tempPacket);

        delete username;
        delete packet->data;
        delete packet;
        return -1;
    }
    else {
        // Check the password.
        Protocol::getLOGINPassword(packet, password);
        char * dbPassword;
        cMan->queryExecuter.getPassword(username, dbPassword);
        if (strcmp(password, dbPassword) != 0) {
            NAIMpacket * tempPacket = Protocol::createNACK();
            addOutputPacket(tempPacket);

            delete username;
            delete password;
            delete dbPassword;
            delete packet->data;
            delete packet;
            return -1;
        }
    
        // If all is ok send ACK
        NAIMpacket * tempPacket = Protocol::createACK();
        addOutputPacket(tempPacket);

        delete password;
        delete dbPassword;
    }

    char * status;
    Protocol::getLOGINStatus(packet, status);

    // Check if anybody is already using this connection
    if (clientName != NULL) {
        // If it's the same user, check if the status changed and notify all contacts
        if (strcmp(clientName, username) == 0) {
            if (strcmp(cMan->getStatus(username), status) != 0) {
                cMan->setStatus(username, status);
                cMan->notifyOfStatusChange(username, status);
            }
        }
        // Else disconnect the old user.
        else {
            cMan->clientDisconnect(username);
            delete clientName;
            clientName = NULL;
        }
    }
    // If the client hasn't been using this connection before, check if he is not logged in on other connection.
    if (clientName == NULL) {
        unsigned short uLen = strlen(username);
        clientName = new char[uLen + 1];
        memcpy(clientName, username, uLen);

        // If the client is already logged in on another connection, log him out on that connection
        if (cMan->isOnline(username)) {
            cMan->userConnectedRemotely(username);
        }
        cMan->notifyOfStatusChange(username, status);
    }

    delete status;


    // Send the contacts list
    // TODO: Do this in a better way. Maybe in the Protocol class

    string availability = "";
    string statuses = "";

    char * contactsBuffer;
    unsigned short contactsBufferLen;
    cMan->queryExecuter.getContactsBuffer(username, contactsBuffer, contactsBufferLen);
    char * pointer = contactsBuffer;

    int groupsNo = (unsigned char)*pointer++;
    for (int i = 0; i < groupsNo; ++i) {
        int groupLen = (unsigned char)*pointer++;
        pointer += groupLen;
        int usersNo = (unsigned char)*pointer++;
        for (int j = 0; j < usersNo; ++j) {
            int userLen = (unsigned char)*pointer++;
            string user = string(pointer, userLen);
            pointer += userLen;

            if (cMan->onlineClients.count(user) > 0) {
                availability += (char)1;
                statuses += cMan->onlineClients[user];
            }
            else {
                // WARNING: This is dangerous.
                availability += (char)0;
            }
        }
    }

    char * data = new char[contactsBufferLen + availability.size() + statuses.size()];
    memcpy(data, contactsBuffer, contactsBufferLen);
    memcpy(data + contactsBufferLen, availability.data(), availability.size());
    memcpy(data + contactsBufferLen + availability.size(), statuses.data(), statuses.size());

    NAIMpacket * tempPacket = Protocol::createUSER_LIST(data, contactsBufferLen + availability.size() + statuses.size());
    addOutputPacket(tempPacket);
    delete data;

    delete username;
    delete packet->data;
    delete packet;
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

/*
 *	STATUS
 */
int Peer::processSTATUS(NAIMpacket * packet) {
    // TODO: check if sender is the same as clientName
    // Notify all of it's contacts
    char * status;
    Protocol::getLOGINStatus(packet, status);

    cMan->notifyOfUserConnect(clientName, status);

    delete status;
    delete packet->data;
    delete packet;
    return 0;
}
/*
 *	CONNECTION_CLOSED
 */
int Peer::processCONNECTION_CLOSED(NAIMpacket * packet) {
    disposable = true;
    if (clientName != NULL) {
        cMan->clientDisconnect(clientName);
        delete clientName;
        clientName = NULL;
    }
    
    delete packet;
    return 0;
}
/*
 *	DISCONNECT
 */
int Peer::processDISCONNECT(NAIMpacket * packet) {
    addOutputPacket(packet);
    disposable = true;
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
            case PING: {
                time(&lastActiveTime);
                break;
                    }
            case SIGN_UP: {
                time(&lastActiveTime);
                processSIGN_UP(packet);
                break;
                    }
            case LOGIN: {
                time(&lastActiveTime);
                processLOGIN(packet);
                break;
                    }
            case TEXT: {
                time(&lastActiveTime);
                processTEXT(packet);
                break;
                    }
            case CONNECTION_REQ: {
                time(&lastActiveTime);
                processCONNECTION_REQ(packet);
                break;
                    }
            case CONNECTION_DATA: {
                time(&lastActiveTime);
                processCONNECTIONDATA(packet);
                break;
                    }
            case STATUS: {
                time(&lastActiveTime);
                processSTATUS(packet);
                break;                      
                    }
            case CONNECTION_CLOSED: {
                processCONNECTION_CLOSED(packet);
                break;
                    }
            case DISCONNECT: {
                processDISCONNECT(packet);
                break;
                     }
        }

        inputQueue.pop();
    } 
    return 0;
}

/*
 *	Disconnects the user.
 */
int Peer::disconnect(NAIMpacket * packetDISCONNECT) {
    while (inputQueue.size() > 0)
        inputQueue.pop();
    inputQueue.push(packetDISCONNECT);
    return 0;
}

/*
 *	Pings the client
 */
int Peer::ping() {
    outputQueue.push(Protocol::createPING());
    return 0;
}

