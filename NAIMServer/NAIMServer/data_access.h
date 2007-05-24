#ifndef DATA_ACCESS_H
#define DATA_ACCESS_H

#include <sqlite3.h>

/* Holds details about a client */

struct ClientDetails {
    int dbID;
    char * username;
    char * password;
};

/* Holds details about a group */

struct GroupDetails {
    int dbID;
    char * name;
};

/* Contains functions for database access */

class IQueryExecuter {
public:
    
    /* Adds a new client to the database */
    virtual void addClient(const char * username, const char * password) = 0;
    
    /* Adds the group groupName in the list of the client clientName*/
    virtual void addGroup(const char * groupName, const char * clientName) = 0;
    
    /* Adds the contact contactName in the group groupName in the list of the client clientName*/
    virtual void addContact(const char * contactName, const char * groupName, const char * clientName) = 0;
    
    /* Deletes a client */
    virtual void deleteClient(const char * clientName) = 0;
    
    /* Deletes the group groupName from the list of the client clientName */
    virtual void deleteGroup(const char * groupName, const char * clientName) = 0;
    
    /* Deletes the contact contactName from clientName's list */
    virtual void deleteContact(const char * contactName, const char * clientName) = 0;
    
    /* Moves contactName in clientName' list to the group groupName */
    virtual void moveContatct(const char *contactName, const char * clientName, const char * groupName) = 0;
    
    /* Returns details about clientName */
    virtual ClientDetails getClient(const char * clientName) = 0;
    
    /* Returns a list with all the clients in the database */
    virtual ClientDetails * getContactsList(ClientDetails *& clients, unsigned int & contactsNo) = 0;
    
    /* Returns a list with all the groups in clientName's list */
    virtual GroupDetails * getGroupsList(const char * clientName, GroupDetails *& groups, unsigned int & groupsNo) = 0;
    
    /* Returns a list with all the contacts in clientName's list */
    virtual ClientDetails * getContactsList(const char * clientName, ClientDetails *& contacts, unsigned int & contactsNo) = 0;
    
    /* Returns true if the client clientName is in the database */
    virtual bool isClient(const char * clientName) = 0;

    /* Opens the database at the specified path */
    virtual int openDB(const char * path) = 0;
};

class QueryExecuter : IQueryExecuter {
    sqlite3 * database;
};

#endif  /* DATA_ACCESS_H */

