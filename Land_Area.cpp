#include <iostream>
#include <cstdlib>
#include <ctime>
#include <cmath> // dla sqrt

using namespace std;

const int X_DIM = 5000;
const int Y_DIM = 4000;
const int MIN_HEIGHT = 1200;
const int MAX_HEIGHT = 3500;
const double STEP_SIZE = 1.0;

int main() {
    srand(time(nullptr));

    // Dynamiczna alokacja tablicy 2D
    int** height = new int*[X_DIM];
    for (int i = 0; i < X_DIM; ++i) {
        height[i] = new int[Y_DIM];
    }

    for (int x = 0; x < X_DIM; ++x) {
        for (int y = 0; y < Y_DIM; ++y) {
            height[x][y] = MIN_HEIGHT + rand() % (MAX_HEIGHT - MIN_HEIGHT + 1);
        }
    }

    // Obliczanie pola powierzchni terenu
    double total_area = 0.0;
    for (int x = 0; x < X_DIM - 1; ++x) {
        for (int y = 0; y < Y_DIM - 1; ++y) {
            // Obliczamy ró¿nice wysokoœci miêdzy s¹siaduj¹cymi punktami
            double dzdx = (height[x + 1][y] - height[x][y]) * STEP_SIZE; //wzd³u¿ X
            double dzdy = (height[x][y + 1] - height[x][y]) * STEP_SIZE; //wzd³u¿ Y

            // Obliczamy odleg³oœæ w trzech wymiarach miêdzy s¹siednimi punktami
            double dx = sqrt(STEP_SIZE * STEP_SIZE + dzdx * dzdx); // odleg³oœæ wzd³u¿ osi X (uwzglêdniaj¹c wysokoœæ)
            double dy = sqrt(STEP_SIZE * STEP_SIZE + dzdy * dzdy); // odleg³oœæ wzd³u¿ osi Y (uwzglêdniaj¹c wysokoœæ)

            total_area += dx * dy;
        }
    }

    total_area /= 1000000.0;

    cout << "Pole powierzchni terenu: " << total_area << " km^2" << endl;

    // Usuniêcie dynamicznie zaalokowanej pamiêci
    for (int i = 0; i < X_DIM; ++i) {
        delete[] height[i];
    }
    delete[] height;

    return 0;
}
