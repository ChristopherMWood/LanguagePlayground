#include "Shape.h"

class Rectangle : Shape
{
    public:
        Rectangle(int width, int height) : Shape(width, height) {};
        int Area();
};