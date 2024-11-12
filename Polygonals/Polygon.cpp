#include "Polygon.h"
#include <cmath>


Polygon::Polygon(const std::vector<Punkt_2>& vertices) : vertices(vertices) {}

Polygon::Polygon(const Polygon& other) : vertices(other.vertices) {}

Polygon& Polygon::operator=(const Polygon& other) {
    if (this != &other) {
        vertices = other.vertices;
    }
    return *this;
}


Punkt_2& Polygon::operator[](std::size_t index) {
    return vertices.at(index);
}

const Punkt_2& Polygon::operator[](std::size_t index) const {
    return vertices.at(index);
}

std::ostream& operator<<(std::ostream& os, const Polygon& polygon) {
    os << "Polygon with vertices: ";
    for (const auto& vertex : polygon.vertices) {
        os << vertex << " ";
    }
    return os;
}

// Shoelace formula
double Polygon::calculateArea() const {
    double area = 0.0;
    std::size_t n = vertices.size();
    for (std::size_t i = 0; i < n; ++i) {
        const Punkt_2& current = vertices[i];
        const Punkt_2& next = vertices[(i + 1) % n];
        area += (current.getX() * next.getY()) - (next.getX() * current.getY());
    }
    return std::abs(area) / 2.0;
}

// is convex!?????
bool Polygon::isConvex() const {
    std::size_t n = vertices.size();
    if (n < 4) return true; // triangle baby, that's what im talking about

    bool isPositive = false;
    for (std::size_t i = 0; i < n; ++i) {
        const Punkt_2& p0 = vertices[i];
        const Punkt_2& p1 = vertices[(i + 1) % n];
        const Punkt_2& p2 = vertices[(i + 2) % n];

        float crossProduct = (p1.getX() - p0.getX()) * (p2.getY() - p1.getY()) -
                             (p1.getY() - p0.getY()) * (p2.getX() - p1.getX());

        if (i == 0) {
            isPositive = crossProduct > 0;
        } else if ((crossProduct > 0) != isPositive) {
            return false;
        }
    }
    return true;
}

double Polygon::boundedArea() const {
    return calculateArea();
}

std::size_t Polygon::getVertexCount() const {
    return vertices.size();
}
