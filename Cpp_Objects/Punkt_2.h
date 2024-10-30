//
// Created by student on 30.10.2024.
//

#ifndef PUNKT_2_H
#define PUNKT_2_H

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




};



#endif //PUNKT_2_H
