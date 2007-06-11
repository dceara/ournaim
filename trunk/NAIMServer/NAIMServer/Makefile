SRC=$(wildcard *.cpp)
HDR=$(wildcard *.h)

all: debug

./bin/sqlite3.o: ./SqLite/sqlite3.c
	gcc -c -o ./bin/sqlite3.o ./SqLite/sqlite3.c

release: $(SRC) $(HDR) ./bin/sqlite3.o
	g++ -O3 -ISqLite -lpthread -ldl -o ./bin/server ./bin/sqlite3.o $(SRC)

debug: $(SRC) $(HDR) ./bin/sqlite3.o
	g++ -Wall -g3 -O0 -ISqLite -lpthread -ldl -o ./bin/server ./bin/sqlite3.o $(SRC)
