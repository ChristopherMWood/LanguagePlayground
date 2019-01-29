#include "Shape.h"

class Triangle : Shape
{
    public:
        Triangle(int width, int height) : Shape(width, height) {};
        int Area();
};