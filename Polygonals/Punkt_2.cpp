#include "Punkt_2.h"

Punkt_2::Punkt_2() : x(0.0f), y(0.0f) {}
Punkt_2::Punkt_2(float xVal, float yVal) : x(xVal), y(yVal) {}
Punkt_2::Punkt_2(const Punkt_2& other) : x(other.x), y(other.y) {}

void Punkt_2::setX(float xVal) { x = xVal; }
void Punkt_2::setY(float yVal) { y = yVal; }
float Punkt_2::getX() const { return x; }
float Punkt_2::getY() const { return y; }

Punkt_2& Punkt_2::operator=(const Punkt_2& other) {
    if (this != &other) {
        x = other.x;
        y = other.y;
    }
    return *this;
}

// add
Punkt_2 Punkt_2::operator+(const Punkt_2& other) const {
    return Punkt_2(x + other.x, y + other.y);
}

// sub
Punkt_2 Punkt_2::operator-(const Punkt_2& other) const {
    return Punkt_2(x - other.x, y - other.y);
}

float Punkt_2::operator*(const Punkt_2& other) const {
    return x * other.x + y * other.y;
}

float Punkt_2::magnitude() const {
    return std::sqrt(x * x + y * y);
}

std::ostream& operator<<(std::ostream& os, const Punkt_2& punkt) {
    os << "(" << punkt.x << ", " << punkt.y << ")";
    return os;
}
