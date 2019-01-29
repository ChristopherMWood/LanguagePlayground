#include "Shape.h"

template <typename T>
class Rectangle : public Shape<T>
{
    public:
        Rectangle(T width, T height) : Shape<T>(width, height) {};
        T Area();
};

template <typename T>
T Rectangle<T>::Area()
{
    return this->height * this->width;
}