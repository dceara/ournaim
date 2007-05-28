#include "data_access.h"

void QueryExecuter::addClient(const char * username, const char * password) {

}

void QueryExecuter::addGroup(const char * groupName, const char * clientName) {

}

void QueryExecuter::addContact(const char * contactName, const char * groupName, const char * clientName) {

}

void QueryExecuter::deleteClient(const char * clientName) {

}

void QueryExecuter::deleteGroup(const char * groupName, const char * clientName) {

}

void QueryExecuter::deleteContact(const char * contactName, const char * clientName) {

}

void QueryExecuter::moveContatct(const char *contactName, const char * clientName, const char * groupName) {

}

ClientDetails QueryExecuter::getClient(const char * clientName) {
    return ClientDetails();
}

ClientDetails * QueryExecuter::getContactsList(ClientDetails *& clients, unsigned int & contactsNo) {
    return NULL;
}

GroupDetails * QueryExecuter::getGroupsList(const char * clientName, GroupDetails *& groups, unsigned int & groupsNo) {
    return NULL;
}

ContactDetails * QueryExecuter::getContactsList(const char * clientName, ClientDetails *& contacts, unsigned int & contactsNo) {
    return NULL;
}

bool QueryExecuter::isClient(const char * clientName) {
    return NULL;
}

int QueryExecuter::openDB(const char * path) {
    return NULL;
}