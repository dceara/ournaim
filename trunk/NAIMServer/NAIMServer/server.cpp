#include "connection_manager.h"

#include <cstdio>

using namespace std;

int main(int argc, char * argv[]) {
    
    ConnectionManager cMan = ConnectionManager();
    cMan.run();

    return 0;
}
