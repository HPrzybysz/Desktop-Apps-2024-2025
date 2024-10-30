//
// Created by student on 30.10.2024.
//

#include "Punkt_2.h"

Punkt_2::Punkt_2() : x(0.0f), y(0.0f){}

Punkt_2::Punkt_2(float xVal, float yVal):x(xVal), y(yVal){}

Punkt_2::Punkt_2(const Punkt_2& other):x(other.x), y(other.y){}


void Punkt_2::setX(float xVal)
{
    x = xVal;
}

void Punkt_2::setY(float yVal)
{
    y = yVal;
}


float Punkt_2::getX() const
{
    return x;
}

float Punkt_2::getY() const
{
    return y;
}
