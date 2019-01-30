#ifndef H_SHAPE
#define H_SHAPE

template <typename T>
class Shape
{
    public:
        Shape(T xWidth, T yHeight) : width(xWidth), height(yHeight) {};
        T Area() { return width; };
    protected:
        T width;
        T height;
};

#endif