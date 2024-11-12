#include "Punkt_2.h"
#include "Polygon.h"
#include <iostream>
#include <vector>

int main() {
    Punkt_2 p1;
    std::cout << "Default constructor: " << p1 << std::endl;

    Punkt_2 p2(3.5f, 4.5f);
    std::cout << "Main constructor: " << p2 << std::endl;

    Punkt_2 p3(p1);
    std::cout << "Copy constructor (p1): " << p3 << std::endl;

    p1.setX(50.0f);
    p1.setY(12.5f);
    std::cout << "After using setters: " << p1 << std::endl;

    // asingment test
    p3 = p2;
    std::cout << "After assignment (p3 = p2): " << p3 << std::endl;

    Punkt_2 p4 = p1 + p2;
    std::cout << "Addition (p1 + p2): " << p4 << std::endl;

    Punkt_2 p5 = p1 - p2;
    std::cout << "Subtraction (p1 - p2): " << p5 << std::endl;

    float dotProduct = p1 * p2;
    std::cout << "Dot product (p1 * p2): " << dotProduct << std::endl;

    std::cout << "Magnitude of p1: " << p1.magnitude() << std::endl;
    std::cout << "Magnitude of p2: " << p2.magnitude() << std::endl;


    //Polygon

    std::cout << "\n\nPolygons\n\n" << std::endl;

    //kwadrat
    std::vector<Punkt_2> vertices = {
        Punkt_2(0.0f, 0.0f),
        Punkt_2(4.0f, 0.0f),
        Punkt_2(4.0f, 3.0f),
        Punkt_2(0.0f, 3.0f)
    };

    Polygon poly(vertices);

    // Print polygon vertices: <<
    std::cout << "Polygon: " << poly << std::endl;

    //area of the polygon
    std::cout << "Area of the polygon: " << poly.calculateArea() << std::endl;

    //is convex?
    std::cout << "Is the polygon convex? " << (poly.isConvex() ? "Yes" : "No") << std::endl;

    //array thingy
    std::cout << "First vertex: " << poly[0] << std::endl;

    //copy constructor test
    Polygon polyCopy = poly;
    std::cout << "Copied Polygon: " << polyCopy << std::endl;

    //wonky polygon
    std::cout << "\nNon-Convex Polygon:\n" << std::endl;

    std::vector<Punkt_2> vertices2 = {
        Punkt_2(0.0f, 0.0f),
        Punkt_2(4.0f, 1.0f),
        Punkt_2(1.5f, 2.0f),
        Punkt_2(5.0f, 5.0f),
        Punkt_2(2.0f, 4.0f),
        Punkt_2(4.0f, 8.0f),
        Punkt_2(0.0f, 6.0f),
        Punkt_2(-2.0f, 3.0f)
    };

    Polygon polymoly(vertices2);

    std::cout << "Polygon: " << polymoly << std::endl;
    std::cout << "Area of the polygon: " << polymoly.calculateArea() << std::endl;
    std::cout << "Is the polygon convex? " << polymoly.isConvex() << std::endl;
    std::cout << "First vertex: " << polymoly[0] << std::endl;
    Polygon polyCopy2 = polymoly;
    std::cout << "Copied Polygon: " << polyCopy2 << std::endl;

    return 0;
}
