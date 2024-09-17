#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

const int X = 50;
const int Y = 40;
const int Z = 27;


void printRoom(double room[X][Y][Z]) {
    for (int i = 0; i < X; ++i) {
        cout << "Przekrój X = " << i << ":" << endl;
        for (int j = 0; j < Y; ++j) {
            for (int k = 0; k < Z; ++k) {
                cout << room[i][j][k] << " ";
            }
            cout << endl;
        }
        cout << endl;
    }
}

int main() {
    srand(time(0));


    double room[X][Y][Z];


    for (int i = 0; i < X; ++i) {
        for (int j = 0; j < Y; ++j) {
            for (int k = 0; k < Z; ++k) {
                room[i][j][k] = 18 + (rand() % 800) / 100.0;
            }
        }
    }


    // printRoom(room);

    int bestX = 0;
    double maxAvgTemp = -1;

    // Iteracja przez wszystkie przekroje pionowe dla danej wartoœci X
    for (int i = 0; i < X; ++i) {
        double sumTemp = 0;
        int count = 0;

        // Obliczenie sumy temperatur w przekroju pionowym X = i
        for (int j = 0; j < Y; ++j) {
            for (int k = 0; k < Z; ++k) {
                sumTemp += room[i][j][k];
                ++count;
            }
        }

        double avgTemp = sumTemp / count;

        // Sprawdzenie, czy aktualny przekrój ma wy¿sz¹ œredni¹ temperaturê
        if (avgTemp > maxAvgTemp) {
            maxAvgTemp = avgTemp;
            bestX = i;
        }
    }

    cout << "Przekroj pionowy o indeksie X = " << bestX << " ma najwyzsza srednia temperature: "
         << maxAvgTemp << " stopni." << endl;

    return 0;
}
