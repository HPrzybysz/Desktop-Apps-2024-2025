#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

const int X = 50;
const int Y = 40;
const int Z = 27;

double*** create3DArray(int x, int y, int z) {
    double*** array = new double**[x];
    for (int i = 0; i < x; ++i) {
        array[i] = new double*[y];
        for (int j = 0; j < y; ++j) {
            array[i][j] = new double[z];
        }
    }
    return array;
}

void delete3DArray(double*** array, int x, int y) {
    for (int i = 0; i < x; ++i) {
        for (int j = 0; j < y; ++j) {
            delete[] array[i][j];
        }
        delete[] array[i];
    }
    delete[] array;
}

void printRoom(double*** room, int x, int y, int z) {
    for (int i = 0; i < x; ++i) {
        cout << "Przekrój X = " << i << ":" << endl;
        for (int j = 0; j < y; ++j) {
            for (int k = 0; k < z; ++k) {
                cout << room[i][j][k] << " ";
            }
            cout << endl;
        }
        cout << endl;
    }
}

int main() {
    srand(time(0));

    double*** room = create3DArray(X, Y, Z);

    for (int i = 0; i < X; ++i) {
        for (int j = 0; j < Y; ++j) {
            for (int k = 0; k < Z; ++k) {
                room[i][j][k] = 18 + (rand() % 800) / 100.0;
            }
        }
    }

    int bestX = 0;
    double maxAvgTemp = -1;

    for (int i = 0; i < X; ++i) {
        double sumTemp = 0;
        int count = 0;

        for (int j = 0; j < Y; ++j) {
            for (int k = 0; k < Z; ++k) {
                sumTemp += room[i][j][k];
                ++count;
            }
        }

        double avgTemp = sumTemp / count;

        if (avgTemp > maxAvgTemp) {
            maxAvgTemp = avgTemp;
            bestX = i;
        }
    }

    cout << "Przekroj pionowy o indeksie X = " << bestX << " ma najwyzsza srednia temperature: "
         << maxAvgTemp << " stopni." << endl;

    delete3DArray(room, X, Y);

    return 0;
}
