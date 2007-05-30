SRC=$(wildcard *.cpp)
HDR=$(wildcard *.h)


all: debug


release: $(SRC) $(HDR)
	g++ -O3 -ISqLite -o server $(SRC)

debug: $(SRC) $(HDR)
	g++ -Wall -g3 -O0 -ISqLite -o server $(SRC)
