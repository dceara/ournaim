#ifndef DATA_ACCESS_H
#define DATA_ACCESS_H

#include <sqlite3.h>

#include <map>
#include <vector>

/* Holds details about a client */

struct ClientDetails {
    int dbID;
    std::string username;
    std::string password;
};

struct ContactDetails {
    int dbID;                           // the ID of the username
    std::string username;
    std::string group;
};

/* Holds details about a group */

struct GroupDetails {
    int dbID;
    std::string name;
};

/* Contains functions for database access */

class IQueryExecuter {
public:
    virtual ~IQueryExecuter();
    
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
    virtual char * getContactsList(const char * clientName, char *& buffer, unsigned int & length) = 0;
    
    /* Returns true if the client clientName is in the database */
    virtual bool isClient(const char * clientName) = 0;

    /* Opens the database at the specified path */
    virtual int openDB(const char * path) = 0;
};

class QueryExecuter : public IQueryExecuter {
    sqlite3 * database;

    std::map< std::string, std::string > clients;
    std::map< std::string, std::map< std::string, std::vector < std::string> > > contacts;
public:

    void addClient(const char * username, const char * password);
    void addGroup(const char * groupName, const char * clientName);
    void addContact(const char * contactName, const char * groupName, const char * clientName);
    void deleteClient(const char * clientName);
    void deleteGroup(const char * groupName, const char * clientName);
    void deleteContact(const char * contactName, const char * clientName);
    void moveContatct(const char *contactName, const char * clientName, const char * groupName);
    ClientDetails getClient(const char * clientName);
    ClientDetails * getContactsList(ClientDetails *& clients, unsigned int & contactsNo);
    GroupDetails * getGroupsList(const char * clientName, GroupDetails *& groups, unsigned int & groupsNo);
    char * getContactsList(const char * clientName, char *& buffer, unsigned int & length);
    bool isClient(const char * clientName);
    int openDB(const char * path);
};

#endif  /* DATA_ACCESS_H */

