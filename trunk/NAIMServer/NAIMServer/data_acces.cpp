#include "data_access.h"

#include <map>
#include <string>
#include <vector>

using namespace std;

IQueryExecuter::~IQueryExecuter(){}

QueryExecuter::QueryExecuter() {
    database = NULL;
}

QueryExecuter::~QueryExecuter() {
    if (database != NULL)
        sqlite3_close(database);
}

void QueryExecuter::addClient(const char * username, const char * password) {
	const char first_part[] = "insert into Clienti(UserName, Parola) values(";
	char *errMessage;
	int queryLen = strlen(first_part)+strlen(" '''',)");
	char *query = new char[queryLen + strlen(username) + strlen(password)];
	sprintf(query,"%s'%s','%s')",first_part,username,password);
	bool result = executeNonQuery(query,errMessage);
	if(!result)
		sqlite3_free(errMessage);
	delete []query;
} 

void QueryExecuter::addGroup(const char * groupName, const char * clientName) {

	char *errMessage;
	int rowsCnt;
	int colsCnt;
	const char first_part_group[] = "select count(*) from Grupuri gr where gr.Nume = '";
	const char second_part_group[] = "' and gr.IdClient = (select Id from Clienti where UserName ='";
	const char third_part_group[] = "')";
	char *query = new char[strlen(first_part_group) + strlen(second_part_group) + strlen(third_part_group) + strlen(groupName) + strlen(clientName)  + 1 ];
	sprintf(query,"%s%s%s%s%s",first_part_group,groupName,second_part_group,clientName,third_part_group);
	char **resultTable = executeQuery(query,rowsCnt,colsCnt,errMessage);
	if(rowsCnt < 2)
	{
		if(errMessage != NULL)
			sqlite3_free(errMessage);
	}

	if(strcmp(resultTable[1],"0") != 0)
	{
		return;
	}
	/*cleanup the query results*/
	sqlite3_free_table(resultTable);
	delete []query;

	const char first_part[] = "insert into Grupuri(Nume,IdClient) select '";
	const char second_part[] = "',Id from Clienti where UserName = '";
	
	query = new char[strlen(first_part) + strlen(second_part) + strlen(groupName) + strlen(clientName) + strlen(" '")];
	sprintf(query,"%s%s%s%s'",first_part,groupName,second_part,clientName);
	bool result = executeNonQuery(query,errMessage);
	if(!result)
		sqlite3_free(errMessage);
	delete []query;
}

void QueryExecuter::addContact(const char * contactName, const char * groupName, const char * clientName) {

	char *errMessage;
	int rowsCnt;
	int colsCnt;
	const char first_part_group[] = "select count(*) from Grupuri gr where gr.Nume = '";
	const char second_part_group[] = "' and gr.IdClient = (select Id from Clienti where UserName ='";
	const char third_part_group[] = "')";
	char *query = new char[strlen(first_part_group) + strlen(second_part_group) + strlen(third_part_group) + strlen(groupName) + strlen(clientName)  + 1 ];
	sprintf(query,"%s%s%s%s%s",first_part_group,groupName,second_part_group,clientName,third_part_group);
	char **resultTable = executeQuery(query,rowsCnt,colsCnt,errMessage);
	if(rowsCnt < 2)
	{
		if(errMessage != NULL)
			sqlite3_free(errMessage);
	}

	if(strcmp(resultTable[1],"0") == 0)
	{
		addGroup(groupName,clientName);
	}
	/*cleanup the query results*/
	sqlite3_free_table(resultTable);
	delete []query;

	const char first_part[] = "insert into Contacte(IdGrup,IdClient) select (select Id from Grupuri where Nume = '";
	const char second_part[] = "' and IdClient = (select Id from Clienti where UserName = '";
	const char third_part[] = "')), (select Id from Clienti where UserName = '";
	const char fourth_part[] = "')";
	
	query = new char[strlen(first_part) + strlen(second_part) + strlen(third_part) + strlen (fourth_part) + strlen(groupName) + 
		strlen(clientName) + strlen(contactName) + 1];
	sprintf(query,"%s%s%s%s%s%s%s",first_part,groupName, second_part,clientName,third_part,contactName,fourth_part);
	bool result = executeNonQuery(query,errMessage);
	if(!result)
		sqlite3_free(errMessage);
	delete []query;
}


void QueryExecuter::deleteGroup(const char* groupName, const char *clientName)
{
	char *errMessage;
	int rowsCnt;
	int colsCnt;
	const char first_part_group[] = "select count(*) from Grupuri gr where gr.Nume = '";
	const char second_part_group[] = "' and gr.IdClient = (select Id from Clienti where UserName ='";
	const char third_part_group[] = "')";
	char *query = new char[strlen(first_part_group) + strlen(second_part_group) + strlen(third_part_group) + strlen(groupName) + strlen(clientName)  + 1 ];
	sprintf(query,"%s%s%s%s%s",first_part_group,groupName,second_part_group,clientName,third_part_group);
	char **resultTable = executeQuery(query,rowsCnt,colsCnt,errMessage);
	if(rowsCnt < 2)
	{
		if(errMessage != NULL)
			sqlite3_free(errMessage);
	}
	
	delete []query;
	if(strcmp(resultTable[1],"0") == 0)
	{
		sqlite3_free_table(resultTable);
		return;
	}
	sqlite3_free_table(resultTable);
	const char first_part_delete[] = "delete from Grupuri where Nume = '";
	const char second_part_delete[] = "' and IdClient = (select Id from Clienti where UserName ='";
	const char third_part_delete[] = "')";
	query = new char[strlen(first_part_delete) + strlen(second_part_delete) + strlen(third_part_delete) + strlen(groupName) + strlen(clientName)  + 1 ];
	sprintf(query,"%s%s%s%s%s",first_part_delete,groupName,second_part_delete,clientName,third_part_delete);
	bool result = executeNonQuery(query,errMessage);
	if(!result)
		sqlite3_free(errMessage);
	delete []query;
}

void QueryExecuter::deleteClient(const char * clientName) {
	/* firs delete all the relationships between the client and all the other clients */
	const char first_part_contacts[] = "delete from Contacte where IdClient = (select Id from Clienti where UserName = '";
	const char second_part_contacts[] = "')";
	char *errMessage;
	char *query = new char[strlen(first_part_contacts) + strlen(second_part_contacts) + strlen(clientName) + 1];
	sprintf(query,"%s%s%s",first_part_contacts,clientName,second_part_contacts);
	bool result = executeNonQuery(query,errMessage);
	if(!result)
		sqlite3_free(errMessage);
	delete []query;

	/* delete all the relationships between the other clients and the current client */
	const char first_part_groups[] = "delete from Contacte where IdGrup in \
									 (select Id from Grupuri where IdClient = (select Id from Clienti where UserName = '";
	const char second_part_groups[] = "'))";
	query = new char[strlen(first_part_groups) + strlen(second_part_groups) + strlen(clientName) + 1];
	sprintf(query,"%s%s%s",first_part_groups,clientName,second_part_groups);
	result = executeNonQuery(query,errMessage);
	if(!result)
		sqlite3_free(errMessage);
	delete []query;

	/* delete all his groups */
	const char first_part_gr[] = "delete from Grupuri where IdClient = (select Id from Clienti where UserName = '";
	const char second_part_gr[] = "')";
	query = new char[strlen(first_part_gr) + strlen(second_part_gr) + strlen(clientName) + 1];
	sprintf(query,"%s%s%s",first_part_gr,clientName,second_part_gr);
	result = executeNonQuery(query,errMessage);
	if(!result)
		sqlite3_free(errMessage);
	delete []query;

	/*delete the entry from Clienti*/
	const char first_part_clients[] = "delete from Clienti where UserName = '";
	const char second_part_clients[] = "'";
	query = new char[strlen(first_part_clients) + strlen(second_part_clients) + strlen(clientName) + 1];
	sprintf(query,"%s%s%s",first_part_clients,clientName,second_part_clients);
	result = executeNonQuery(query,errMessage);
	if(!result)
		sqlite3_free(errMessage);
	delete []query;
}

void QueryExecuter::deleteContact(const char * contactName, const char * clientName) {
	const char first_part[] = "delete from Contacte where IdClient = (select Id from Clienti where UserName = '";
	const char second_part[] = "') and IdGrup in (select Id from Grupuri where IdClient = (select Id from Clienti where UserName = '";
	const char third_part[] = "'))";
	char *errMessage;
	char * query = new char[strlen(first_part) + strlen(second_part) + strlen(third_part) + strlen(contactName) + strlen(clientName) + 1];
	sprintf(query,"%s%s%s%s%s",first_part,contactName,second_part,clientName,third_part);
	bool result = executeNonQuery(query,errMessage);
	if(!result)
		sqlite3_free(errMessage);
	delete []query;
}

void QueryExecuter::moveContact(const char *contactName, const char * clientName, const char * groupName) {
	deleteContact(contactName,clientName);
	addContact(contactName,groupName,clientName);
}

char * QueryExecuter::getPassword(const char * clientName, char * & password) {
    const char first_part[] = "select Parola from Clienti where UserName = ";
	int rowsCnt;
	int colsCnt;
	char *errMessage;
	char *query = new char[strlen(first_part)+strlen(clientName)+strlen(" ''")];
	sprintf(query,"%s'%s'",first_part,clientName);
	char **resultTable = executeQuery(query,rowsCnt,colsCnt,errMessage);

	if(rowsCnt < 2)
	{
		if(errMessage != NULL)
			sqlite3_free(errMessage);
		password = NULL;
		return password;
	}

	password = new char[strlen(resultTable[1]) + 1];
	strcpy(password,resultTable[1]);

	/*cleanup the query results*/
	sqlite3_free_table(resultTable);
	delete []query;
    
	return password;
}
char * QueryExecuter::getContactGroup(const char * clientName, const char * contactName)
{
	int rowsCnt;
	int colsCnt;
	char *errMessage;
	const char first_part [] = "select gr.Nume from Grupuri gr inner join Contacte ct\
		on ct.IdGrup = gr.Id inner join Clienti c1 \
		on c1.Id = ct.IdClient inner join Clienti c2 \
		on c2.Id = gr.IdClient \
		where c1.UserName = '";
	const char second_part[] = "' and c2.UserName = '";
	const char third_part[] = "'";
	char *query = new char[strlen(first_part) + strlen(second_part) + strlen (third_part) + strlen(clientName) + strlen(contactName) + 1];
	sprintf(query, "%s%s%s%s%s",first_part,contactName,second_part,clientName,third_part);

	char **resultTable = executeQuery(query,rowsCnt,colsCnt,errMessage);
    delete []query;
	if(rowsCnt < 2)
	{
		if(errMessage != NULL)
			sqlite3_free(errMessage);
		return NULL;
	}
	
	int len = strlen(resultTable[1]);
	char *toReturn = new char[len + 1];
	memcpy(toReturn,resultTable[1],len);
	toReturn[len] = 0;
	sqlite3_free_table(resultTable);
	return toReturn;

}
char ** QueryExecuter::getClientsList(char ** & clientsList, unsigned short & contactsNo) {
	char **clientsTable;
	int rowCnt;
	int colCnt;
	char *errMessage;
	clientsTable = executeQuery("select UserName from Clienti",rowCnt,colCnt,errMessage);
	if(clientsTable == NULL)
	{
		sqlite3_free(errMessage);
		return NULL;
	}
	clientsList = new char *[rowCnt-1];
	for(int i = 1;i<rowCnt;i++)
	{
		int len = strlen(clientsTable[i]);
		clientsList[i-1] = new char[len+1];
		strcpy(clientsList[i-1],clientsTable[i]);
	}

	/*cleanup the query results*/
	sqlite3_free_table(clientsTable);

	contactsNo = rowCnt - 1;
	return clientsList;
}

/* the output buffer is: group_count(1) group_name_len(1) group_name(group_name_len) user_count(1) username_len(1) username(username_len).....*/
char * QueryExecuter::getContactsBuffer(const char * clientName, char *& buffer, unsigned short & length) {
    char *errMessage;
    int rowCnt;
    int colCnt;
    const char first_part_group[] = "select Nume from Grupuri where IdClient = (select Id from Clienti where UserName = '";
    const char second_part_group[] = "')";
    char *query = new char[strlen(first_part_group) + strlen(second_part_group) + strlen(clientName) + 1];
    sprintf(query,"%s%s%s",first_part_group,clientName, second_part_group);
    char **groupsTable = executeQuery(query,rowCnt,colCnt,errMessage);
    if(groupsTable == NULL)
    {
        length = 0;
        buffer = NULL;
        delete []query;
        return buffer;
    }
    delete []query;
    string sbuffer = "";
    //append group count
    sbuffer+=(char)(rowCnt-1);
    for(int i = 1; i < rowCnt;i++)
    {
        //append group_name_len_i

        // bai eu zic ca-ti aloca el automat spatiu cand faci un append :)
        sbuffer+=(char)(strlen(groupsTable[i]));
        sbuffer+=groupsTable[i];
        int usersColCnt;
        int usersRowCnt;
        const char first_part_users[] = " select c.UserName from Clienti c inner join Contacte ct on c.Id = ct.IdClient\
                                        inner join Grupuri g on ct.IdGrup = g.Id\
                                        where g.IdClient = (select c2.Id from Clienti c2 where c2.UserName = '";
        const char second_part_users[] = "') and g.Nume = '";
        const char third_part_users[] = "'";
        query = new char[strlen(first_part_users) + strlen(second_part_users) + strlen(third_part_users) + strlen(groupsTable[i]) + strlen(clientName) + 1];
        sprintf(query,"%s%s%s%s%s",first_part_users,clientName,second_part_users,groupsTable[i],third_part_users);
        char **usersTable = executeQuery(query,usersRowCnt,usersColCnt,errMessage);
        if(usersTable == NULL)
        {
            length = 0;
            buffer = NULL;
            delete []query;
            return buffer;
        }
        //append users_cnt
        sbuffer+=(char)(usersRowCnt-1);
        for(int j = 1; j<usersRowCnt;j++)
        {
            sbuffer+=(char)strlen(usersTable[j]);
            sbuffer+=usersTable[j];
        }
        sqlite3_free_table(usersTable);
        delete []query;
    }
    length = sbuffer.size();
    buffer = new char[length+1];
	memcpy(buffer,sbuffer.c_str(),length);
    //strcpy(buffer,sbuffer.c_str());
    return buffer;
}


/*
 *	Returns a list with all the contacts of the client
 */ 
char ** QueryExecuter::getContactsList(const char * clientName, char **& list, unsigned short & length) {
    char *errMessage;
	int rowCnt;
	int colCnt;
	const char first_part_group[] = "select Nume from Grupuri where IdClient = (select Id from Clienti where UserName = '";
	const char second_part_group[] = "')";
	char *query = new char[strlen(first_part_group) + strlen(second_part_group) + strlen(clientName) + 1];
	sprintf(query,"%s%s%s",first_part_group,clientName, second_part_group);
	char **groupsTable = executeQuery(query,rowCnt,colCnt,errMessage);
	if(groupsTable == NULL)
	{
		length = 0;
		list = NULL;
		delete []query;
		return list;
	}
	delete []query;
    
    char *** usersTables = new char ** [rowCnt];
    int * usersTablesLength = new int[rowCnt];

    length = 0;

	for(int i = 1; i < rowCnt;i++)
	{
		int usersColCnt;
		int usersRowCnt;
		const char first_part_users[] = " select c.UserName from Clienti c inner join Contacte ct on c.Id = ct.IdClient\
										inner join Grupuri g on ct.IdGrup = g.Id\
										where g.IdClient = (select c2.Id from Clienti c2 where c2.UserName = '";
		const char second_part_users[] = "') and g.Nume = '";
		const char third_part_users[] = "'";
		query = new char[strlen(first_part_users) + strlen(second_part_users) + strlen(third_part_users) + strlen(groupsTable[i]) + strlen(clientName) + 1];
		sprintf(query,"%s%s%s%s%s",first_part_users,clientName,second_part_users,groupsTable[i],third_part_users);
		char **usersTable = executeQuery(query,usersRowCnt,usersColCnt,errMessage);
		if(usersTable == NULL)
		{
			length = 0;
			list = NULL;
			delete []query;
			return list;
		}
    
        length += usersRowCnt - 1;
        usersTablesLength[i] = usersRowCnt;
        usersTables[i] = usersTable;
        
		delete []query;
	}
    
    list = new char * [length];
    int index = 0;
    for (int i = 1; i < rowCnt; ++i) {
        for (int j = 1; j < usersTablesLength[i]; ++j) {
            int len = strlen(usersTables[i][j]);
            list[index] = new char[len + 1];
            memcpy(list[index], usersTables[i][j], len);
            list[len] = '\0';
            
            sqlite3_free_table(usersTables[i]);
        }
    }

	return list;
}

char ** QueryExecuter::getClientsToUpdateList(const char * clientName, char **& clientsList, unsigned short & length) {

	char *errMessage;
	int rowCnt;
	int colCnt;
	clientsList = NULL;
	const char first_part[] = "select u2.username from Clienti u inner join Contacte ct \
									on ct.IdClient = u.Id inner join Grupuri gr \
									on gr.Id = ct.IdGrup inner join Clienti u2 \
									on u2.Id = gr.IdClient where u.UserName = '";
	const char second_part[] = "'";

	char *query = new char[strlen(first_part) + strlen(second_part) + strlen(clientName) + 1];
	sprintf(query,"%s%s%s",first_part,clientName,second_part);

	char **usersTable = executeQuery(query,rowCnt,colCnt,errMessage);
	if(usersTable == NULL)
	{
		length = 0;
		delete []query;
		return NULL;
	}
	delete []query;

	length = rowCnt - 1;

	clientsList = new char*[rowCnt - 1];

	for(int i = 1; i<rowCnt;i++)
	{
		int userLen = strlen(usersTable[i]);
		clientsList[i - 1] = new char[userLen + 1];
		memcpy(clientsList[i - 1],usersTable[i],userLen);
		clientsList[i - 1][userLen] = '\0';
	}
	sqlite3_free_table(usersTable);

    return clientsList;
}

bool QueryExecuter::isClient(const char * clientName) {
	const char first_part[] = "select count(*) as cnt from Clienti where UserName = '";
	const char second_part[] = "'";
	int rowCnt;
	int colCnt;
	char *errMessage;
	char *query = new char[strlen(first_part) + strlen(second_part) + strlen(clientName) + 1];
	sprintf(query,"%s%s%s",first_part,clientName,second_part);
	char **tableResult = executeQuery(query, rowCnt, colCnt, errMessage);
	
	if(rowCnt < 2)
	{
		if(errMessage != NULL)
			sqlite3_free(errMessage);
		return false;
	}

	if(atoi(tableResult[1])>0)
	{
		sqlite3_free_table(tableResult);
		return true;
	}
	/*cleanup the query results*/
	sqlite3_free_table(tableResult);
	return false;
}

int QueryExecuter::openDB(const char * path) {

	int result = sqlite3_open(path,&database);
	if(result)
	{
		sqlite3_close(database);
		return 0;
	}
    return 1;
}

char** QueryExecuter::executeQuery(const char *query, int & nrows, int & ncols, char * & errMsg)
{
    if (database == NULL)
        return NULL;

	char **result = NULL;
	int queryResult = sqlite3_get_table(database,query,&result,&nrows,&ncols,&errMsg);
	if(queryResult)
	{
		nrows = 0;
		ncols = 0;
		return NULL;
	}
	nrows++;
	return result;
}

bool QueryExecuter::executeNonQuery(const char *query,char * & errMsg)
{
    if (database == NULL)
        return false;

	int result = sqlite3_exec(database,query,NULL,NULL,&errMsg);
	if(result)
		return false;
	return true;
}

