#include "Punkt_2.h"
#include <iostream>

int main()
{

    Punkt_2 p1;
    std::cout << "default constructor: (" << p1.getX() << "," << p1.getY() << ")" << std::endl;

    Punkt_2 p2(3.5f, 4.5f);
    std::cout<<"using main constructor: (" << p2.getX() << "," << p2.getY() << ")" << std::endl;

    Punkt_2 p3(p1);
    std::cout<< "Copied Punkt_2 p1: (" << p3.getX() << "," << p3.getY() << ")" << std::endl;

    p1.setX(50.0f);
    p1.setY(12.5f);

    std::cout << "After using setters: (" << p1.getX() << "," << p1.getY()<< ")" << std::endl;
    return 0;
}
