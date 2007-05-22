#ifndef UTILS_H
#define UTILS_H

#ifdef WIN32
#define CLOSE(socket) closesocket(socket)
#elif
#define CLOSE(socket) close(socket)
#endif  /* WIN32 */




#endif  /* UTILS_H */
