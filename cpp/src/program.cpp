#include <iostream>
#include "../include/shapes/Rectangle.h"
#include "../include/shapes/Triangle.h"

using namespace std;

void ShapeTest();

int main()
{
    ShapeTest();
    return 0;
}

//Compile: g++ program.cpp ./shapes/*.cpp
void ShapeTest()
{
    Rectangle<float> square = Rectangle<float>(2.2, 22.2);
    Triangle<float> triangle = Triangle<float>(10.8, 5.9);
    cout << "Square Area: " << square.Area() << endl;
    cout << "Triangle Area: " << triangle.Area() << endl;
}