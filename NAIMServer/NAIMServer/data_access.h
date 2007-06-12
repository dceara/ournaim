#ifndef DATA_ACCESS_H
#define DATA_ACCESS_H

#include <sqlite3.h>

#include <map>
#include <vector>

/* The name of the NAIM database */

const char NAIM_DATABASE_NAME[] = "Database/NAIM.db";

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
    
    /* Deletes the contact contactName from clientName's list */
    virtual void deleteContact(const char * contactName, const char * clientName) = 0;
    
    /* Moves contactName in clientName' list to the group groupName */
    virtual void moveContact(const char *contactName, const char * clientName, const char * groupName) = 0;
    
    /* Returns details about clientName */
    virtual char * getPassword(const char * clientName, char * & password) = 0;
    
    /* Returns a list with all the clients in the database */
    virtual char ** getClientsList(char ** & clientsList, unsigned short & contactsNo) = 0;

    /* Returns a list with all the contacts in clientName's list */
    virtual char * getContactsBuffer(const char * clientName, char *& contactsList, unsigned short & length) = 0;

    /* Returns a list with all the contacts in clientName's list */
    virtual char ** getContactsList(const char * clientName, char **& contactsList, unsigned short & length) = 0;

    /* Returns a list with all the clients that have clientName on their contacts list.
     * It is used to notify all those clients of a change in clientName's state.*/
    // TODO
    virtual char ** getClientsToUpdateList(const char * clientName, char **& clientsList, unsigned short & length) = 0;

    /* Returns true if the client clientName is in the database */
    virtual bool isClient(const char * clientName) = 0;

    /* Opens the database at the specified path */
    virtual int openDB(const char * path) = 0;

	/* Executes a returning query and returns the result table as a vector of strings. Returns NULL if the operation fails and sets errMessage*/
	virtual char** executeQuery(const char *query, int &nrows, int & ncols, char * & errMsg) = 0;

	/* Executes a non query and returns true if the operation succeeded. Sets errMessage if operation fails */
	virtual bool executeNonQuery(const char *query, char * & errMessage) = 0;

};

class QueryExecuter : public IQueryExecuter {

    sqlite3 * database;

public:
    QueryExecuter();
    ~QueryExecuter();

    void addClient(const char * username, const char * password);
    void addGroup(const char * groupName, const char * clientName);
    void addContact(const char * contactName, const char * groupName, const char * clientName);
    void deleteClient(const char * clientName);
    void deleteContact(const char * contactName, const char * clientName);
    void moveContact(const char *contactName, const char * clientName, const char * groupName);
    char * getPassword(const char * clientName, char * & password);
    char ** getClientsList(char ** & clientsList, unsigned short & contactsNo);
    char * getContactsBuffer(const char * clientName, char *& buffer, unsigned short & length);
    char ** getContactsList(const char * clientName, char **& buffer, unsigned short & length);
    char ** getClientsToUpdateList(const char * clientName, char **& clientsList, unsigned short & length);
    bool isClient(const char * clientName);
    int openDB(const char * path);
	char** executeQuery(const char *query, int & nrows, int &ncols, char * & errMsg);
	bool executeNonQuery(const char *query, char * & errMessage);
};

#endif  /* DATA_ACCESS_H */

