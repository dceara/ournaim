#ifndef UTILS_H
#define UTILS_H

/* Defines for portability issues */

#ifdef WIN32

/* Closes a socket */
#define CLOSE(socket) closesocket(socket)

#elif

#define CLOSE(socket) close(socket)

#endif  /* WIN32 */

/* Functions for reading from buffers */

int readInt(const char * buffer, unsigned int & pointer);
int readInt(const char * buffer);
unsigned int readUInt(const char * buffer, unsigned int & pointer);
unsigned int readUInt(const char * buffer);
short readShort(const char * buffer, unsigned int & pointer);
short readShort(const char * buffer);
unsigned short readUShort(const char * buffer, unsigned int & pointer);
unsigned short readUShort(const char * buffer);

void writeUShort(unsigned short val, const char * buffer, unsigned int & pointer);
void writeUShort(unsigned short val, const char * buffer);

#endif  /* UTILS_H */

