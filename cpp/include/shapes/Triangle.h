#include "Shape.h"

template <typename T>
class Triangle : public Shape<T>
{
    public:
        Triangle(T width, T height) : Shape<T>(width, height) {};
        T Area();
};

template <typename T>
T Triangle<T>::Area()
{
    return (this->width * this->height) / 2;
}