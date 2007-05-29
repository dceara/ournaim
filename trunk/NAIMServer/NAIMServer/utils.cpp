#include "utils.h"

int readInt(const char * buffer, unsigned int & pointer) {
    int temp = *(int *)(buffer + pointer);
    pointer += sizeof(int);
    return temp;
}
int readInt(const char * buffer) {
    return *(int *)buffer;
}
unsigned int readUInt(const char * buffer, unsigned int & pointer) {
    unsigned int temp = *(unsigned int *)(buffer + pointer);
    pointer += sizeof(int);
    return temp;
}
unsigned int readUInt(const char * buffer) {
    return *(unsigned int *)buffer;
}
short readShort(const char * buffer, unsigned int & pointer) {
    short temp = *(short *)(buffer + pointer);
    pointer += sizeof(short);
    return temp;
}
short readShort(const char * buffer) {
    return *(short *)buffer;
}
unsigned short readUShort(const char * buffer, unsigned int & pointer) {
    unsigned short temp = *(unsigned short *)(buffer + pointer);
    pointer += sizeof(short);
    return temp;
}
unsigned short readUShort(const char * buffer) {
    return *(unsigned short *)buffer;
}

void writeUShort(unsigned short val, const char * buffer, unsigned int & pointer) {
    *(unsigned short *)(buffer + pointer) = val;
    pointer += sizeof(short);
}

void writeUShort(unsigned short val, const char * buffer) {
    *(unsigned short *)buffer = val;
}