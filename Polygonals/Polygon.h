#ifndef POLYGON_H
#define POLYGON_H

#include "Punkt_2.h"
#include <vector>
#include <iostream>

class Polygon
{
private:
    std::vector<Punkt_2> vertices;

public:

    Polygon() = default;
    Polygon(const std::vector<Punkt_2>& vertices);
    Polygon(const Polygon& other);


    Polygon& operator=(const Polygon& other);
    Punkt_2& operator[](std::size_t index);
    const Punkt_2& operator[](std::size_t index) const;
    friend std::ostream& operator<<(std::ostream& os, const Polygon& polygon);

    double calculateArea() const;
    bool isConvex() const;
    double boundedArea() const;

    std::size_t getVertexCount() const;
};

#endif // POLYGON_H
