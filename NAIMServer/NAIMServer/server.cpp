#ifdef WIN32
#include <windows.h>
#else
#include <unistd.h>
#include <sys/types.h> 
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#endif

#include <sqlite3.h>
#include <pthread.h>
#include "Utils.h"

#include <cstdio>
#include <cstring>
#include <cstdlib>

using namespace std;

#define YES	"Yes"
#define NO	"No"
#define SERVER_BANNER	"Hi! Ask me a question and I'll say Yes or No"
#define MAX_CLIENTS	5

sqlite3 *db;
char *zErrMsg = 0;
int rc;
static int terminate = 0;

static int callback(void *, int argc, char **argv, char **azColName){
  int i;
  for(i=0; i<argc; i++){
    printf("%s = %s\n", azColName[i], argv[i] ? argv[i] : "NULL");
  }
  printf("\n");
     return 0;
}

int exec(char* statement){
  
  rc = SQLITE_OK;
  do {
    rc = sqlite3_exec(db, statement, callback, 0, &zErrMsg);
    if( rc!=SQLITE_OK ){
        fprintf(stderr, "SQL error: %s\n", zErrMsg);
        sqlite3_free(zErrMsg);
    }
  }while (rc == SQLITE_BUSY);

  return 0;
}


void error(char *msg)
{
    perror(msg);
    exit(1);
}
void *clientThread(void *_clientSocks)
{
	int *clientSocks = (int*)_clientSocks;
	int clientSockWrite = clientSocks[1];
	int clientSockRead = clientSocks[0];
	char buffer[256];
	printf("DEBUG sockNr= %d %d\n",clientSockWrite,clientSockRead);
	while(1)
	{		
		int n;
		memset(buffer,0,256);
			// am primit date
		if ((n = recv(clientSockRead, buffer, sizeof(buffer), 0)) <= 0) 
		{
			if (n == 0) {
				//conexiunea s-a inchis
				printf("selectserver: socket %d hung up\n", clientSockRead);
				return 0;
			} else {
				error("ERROR in recv");
			}
			
            CLOSE(clientSockRead);
		} else {
			printf("RECEIVED %s",buffer);
            exec(buffer);
			//if (random() % 2 == 0)
				n = send(clientSockWrite, YES, strlen(YES), 0); 
			//else							
		//		n = send(clientSockWrite, NO, strlen(NO), 0) ;
			if (n < 0)
				error("ERROR in send");
		}
	}
}
void MyCreateThread(int clientSockWrite,int clientSockRead)
{
	pthread_t thread;
	int *clientSocks = (int*)calloc(2,sizeof(int));
	clientSocks[0] = clientSockWrite;
	clientSocks[1] = clientSockRead;
	pthread_create (&thread, NULL, &clientThread, clientSocks);
}

void* commandThread(void *) {
    char buffer[256];
    while(1) {
        memset(buffer, 0, 256);
        fgets(buffer, 255, stdin);
        if (strncmp("terminate", buffer, 9) == 0) {
            terminate = 1;
            return 0;
        }
    }
}

void CreateCommandThread() {
    pthread_t thread;
	pthread_create (&thread, NULL, &commandThread, NULL);
}

void* connectionListenerThread(void* port) {
     int sockfd, newsockfd;
     unsigned short portno;
     int clilen;
     struct sockaddr_in serv_addr, cli_addr;
     int n, i;

     fd_set read_fds;	//fd_set folosit in select()
     fd_set tmp_fds;	//fd_set folosit temporar
     int fdmax;		//nr maxim de file descriptori

     #ifdef WIN32
     WSADATA wsaData;
     WSAStartup(0x0101, &wsaData);		
     #endif
	

     //golim read_fds
     FD_ZERO(&read_fds);
     FD_ZERO(&tmp_fds);
     
     sockfd = socket(AF_INET, SOCK_STREAM, 0);
     if (sockfd < 0) 
        error("ERROR opening socket");
     
     portno = atoi((char*)port);

     memset((char *) &serv_addr, 0, sizeof(serv_addr));
     serv_addr.sin_family = AF_INET;
     serv_addr.sin_addr.s_addr = INADDR_ANY;	// foloseste adresa IP a masinii
     serv_addr.sin_port = htons(portno);
     
     if (bind(sockfd, (struct sockaddr *) &serv_addr, sizeof(struct sockaddr)) < 0) 
              error("ERROR on binding");
     
     listen(sockfd, MAX_CLIENTS);

     //adaugam noul file descriptor in multimea read_fds
     FD_SET(sockfd, &read_fds);
     fdmax = sockfd;

     // main loop
     for(;;) {
	tmp_fds = read_fds; 
	//printf("\nnumfd = %d\n",fdmax+1);
	if (select(fdmax + 1, &tmp_fds, NULL, NULL, NULL) == -1) 
		error("ERROR in select");
	
	for(i = 0; i <= fdmax; i++) {
		if (FD_ISSET(i, &tmp_fds)) {
			if (i == sockfd) {
				// o noua conexiune
				clilen = (int)sizeof(cli_addr);
				if ((newsockfd = accept(sockfd, (struct sockaddr *)&cli_addr, &clilen)) == -1) {
					error("ERROR in accept");
				} else {
					FD_SET(newsockfd, &read_fds);
					if (newsockfd > fdmax) { 
						
						fdmax = newsockfd;
					}
					printf("selectserver: new connection from %s\n ", inet_ntoa(cli_addr.sin_addr));
					//trimitem banner
     					n = send(newsockfd, SERVER_BANNER, strlen(SERVER_BANNER), 0);
     					if (n < 0)
	     					error("ERROR writing to socket");
					
					MyCreateThread(newsockfd,newsockfd);
				}
			} 
		}
	}
        if (terminate) {
            break;
        }
     }

     sqlite3_close(db);
    
     CLOSE(newsockfd);
    
     return 0;
}

void CreateConnectionListenerThread(char* port) {
    pthread_t thread;
	pthread_create (&thread, NULL, &connectionListenerThread, port);
}

int main(int argc, char *argv[])
{
     if (argc < 3) {
         fprintf(stderr,"Usage : %s port daqtabase\n", argv[0]);
         exit(1);
     }
    
     rc = sqlite3_open(argv[2], &db);
    if( rc ){
        fprintf(stderr, "Can't open database: %s\n", sqlite3_errmsg(db));
        sqlite3_close(db);
        exit(1);
    }

    CreateCommandThread();
    CreateConnectionListenerThread(argv[1]);

    while(!terminate); 

    return 0; 
}



