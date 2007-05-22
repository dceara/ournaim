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

/* Contains functions for database acces */

interface IQueryExecuter {

};

#endif  /* DATA_ACCESS_H */