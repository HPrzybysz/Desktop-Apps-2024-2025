#include <iostream>
#include <cmath>
using namespace std;


void QuadFunction(double a, double b, double c) {
    double delta = b * b - 4 * a * c;

    if (delta < 0) {
        cout << "The equation doesn't have results" << endl;
    }
    else if (delta == 0) {

        cout << "The equation has one double root: x = " << -b / (2 * a) << endl;
    }
    else {
        double sqrt_delta = sqrt(delta);
        cout << "The roots of the equation are: x1 = " << (-b + sqrt_delta) / (2 * a)
            << " oraz x2 = " << (-b - sqrt_delta) / (2 * a) << endl;
    }
}

double TriangleField(double x1, double y1, double x2, double y2, double x3, double y3) {

    return 0.5 * abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
}

int main() {

    QuadFunction(1, -4, -5);

    double x1 = 0.0, y1 = 0.0;
    double x2 = 4.0, y2 = 0.0;
    double x3 = 0.0, y3 = 3.0;


    cout << "Field of triangle: " << TriangleField(x1, y1, x2, y2, x3, y3) << "cm^2" << endl;

    return 0;
}