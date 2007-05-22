#ifndef UTILS_H
#define UTILS_H
#endif

#ifdef WIN32
#define CLOSE(socket) closesocket(socket)
#elif
#define CLOSE(socket) close(socket)
#endif