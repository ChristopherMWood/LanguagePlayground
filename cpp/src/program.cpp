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
    Rectangle square = Rectangle(2, 2);
    Triangle triangle = Triangle(10, 5);
    cout << "Square Area: " << square.Area() << endl;
    cout << "Triangle Area: " << triangle.Area() << endl;
}