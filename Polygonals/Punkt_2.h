#ifndef PUNKT_2_H
#define PUNKT_2_H

#include <iostream>
#include <cmath>

class Punkt_2
{
private:
    float x;
    float y;

public:

    Punkt_2();
    Punkt_2(float xVal, float yVal);
    Punkt_2(const Punkt_2& other);


    void setX(float xVal);
    void setY(float yVal);
    float getX() const;
    float getY() const;

    // assignment
    Punkt_2& operator=(const Punkt_2& other);

    // add sub
    Punkt_2 operator+(const Punkt_2& other) const;
    Punkt_2 operator-(const Punkt_2& other) const;

    // iloczyn skalarny
    float operator*(const Punkt_2& other) const;

    // wektor
    float magnitude() const;

    // funkcja zaprzysjazniona
    friend std::ostream& operator<<(std::ostream& os, const Punkt_2& punkt);
};

#endif //PUNKT_2_H
