#include "data_access.h"

#include <map>
#include <string>
#include <vector>

using namespace std;

IQueryExecuter::~IQueryExecuter() {

}

void QueryExecuter::addClient(const char * username, const char * password) {
    clients.insert(pair< string, string >(string(username), string(password)));
}

void QueryExecuter::addGroup(const char * groupName, const char * clientName) {
    contacts[string(clientName)].insert(pair< string, vector< string > >(string(groupName), vector< string >(0)));
}

void QueryExecuter::addContact(const char * contactName, const char * groupName, const char * clientName) {
    contacts[string(clientName)][string(groupName)].push_back(string(contactName));
}

void QueryExecuter::deleteClient(const char * clientName) {
    clients.erase(string(clientName));
}

void QueryExecuter::deleteGroup(const char * groupName, const char * clientName) {
    contacts[string(clientName)].erase(string(groupName));
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

char * QueryExecuter::getContactsList(const char * clientName, char *& buffer, unsigned int & length) {
    map< string, vector < string > >::iterator it;    
    string sbuffer = "";
    for (it = contacts[string(clientName)].begin(); it != contacts[string(clientName)].end(); ++it) {
        sbuffer += (unsigned char)it->first.size();
        sbuffer += it->first;
        for (unsigned int i = 0; i < it->second.size(); ++i) {
            sbuffer += (unsigned char)it->second[i].size();
            sbuffer += it->second[i];
        }
    }
    return NULL;
}

bool QueryExecuter::isClient(const char * clientName) {
    if (clients.count(string(clientName)) > 0) {
        return true;
    }
    return false;
}

int QueryExecuter::openDB(const char * path) {
    return 0;
}
