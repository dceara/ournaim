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
unsigned int readUInt(const char * buffer, unsigned int & pointer);
short readShort(const char * buffer, unsigned int & pointer);
unsigned short readUShort(const char * buffer, unsigned int & pointer);

#endif  /* UTILS_H */
