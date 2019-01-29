#ifndef H_SHAPE
#define H_SHAPE

class Shape
{
    public:
        Shape(int xWidth, int yHeight) : width(xWidth), height(yHeight) {};
        int Area() { return 0; };
        protected:
            int width;
            int height;
};

#endif