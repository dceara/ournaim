#ifndef DATA_ACCESS_H
#define DATA_ACCESS_H

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

interface IQueryExecuter {
public:
    
    /* Adds a new client to the database */
    void addClient(const char * username, const char * password);
    
    /* Adds the group groupName in the list of the client clientName*/
    void addGroup(const char * groupName, const char * clientName);
    
    /* Adds the contact contactName in the group groupName in the list of the client clientName*/
    void addContact(const char * contactName, const char * groupName, const char * clientName);
    
    /* Deletes a client */
    void deleteClient(const char * clientName);
    
    /* Deletes the group groupName from the list of the client clientName */
    void deleteGroup(const char * groupName, const char * clientName);
    
    /* Deletes the contact contactName from clientName's list */
    void deleteContact(const char * contactName, const char * clientName);
    
    /* Moves contactName in clientName' list to the group groupName */
    void moveContatct(const char *contactName, const char * clientName, const char * groupName);
    
    /* Returns details about clientName */
    ClientDetails getClient(const char * clientName);
    
    /* Returns a list with all the clients in the database */
    ClientDetails * getContactsList(ClientDetails *& clients, unsigned int & contactsNo);
    
    /* Returns a list with all the groups in clientName's list */
    GroupDetails * getGroupsList(const char * clientName, GroupDetails *& groups, unsigned int & groupsNo);
    
    /* Returns a list with all the contacts in clientName's list */
    ClientDetails * getContactsList(const char * clientName, ClientDetails *& contacts, unsigned int & contactsNo);
    
    /* Returns true if the client clientName is in the database */
    bool isClient(const char * clientName);

    /* Opens the database at the specified path */
    int openDB(const char * path);
};

class QueryExecuter : IQueryExecuter {
    sqlite3 * database;
};

#endif  /* DATA_ACCESS_H */