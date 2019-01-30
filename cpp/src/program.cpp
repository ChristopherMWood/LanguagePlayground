#include <iostream>
#include "../include/shapes/Rectangle.h"
#include "../include/shapes/Triangle.h"
#include "../include/family/Mother.h"
#include "../include/family/Daughter.h"
#include "../include/dataStructures/Stack.h"

using namespace std;

void StackTest();
void FamilyTest();
void ShapeTest();

int main()
{
    cout << "Starting..." << endl;
    Stack<int> stack();
    cout << "Finished..." << endl;
    return 0;
}

void StackTest()
{
    
}

void FamilyTest()
{
    Mother mom("Ruby");
    Daughter kid("Sally");
    cout << mom.Title() << ": " << mom.Name() << endl;
    cout << kid.Title() << ": " << kid.Name() << endl;
}

//Compile: g++ program.cpp ./shapes/*.cpp
void ShapeTest()
{
    Rectangle<float> square = Rectangle<float>(2.2, 22.2);
    Triangle<float> triangle = Triangle<float>(10.8, 5.9);
    cout << "Square Area: " << square.Area() << endl;
    cout << "Triangle Area: " << triangle.Area() << endl;
}
