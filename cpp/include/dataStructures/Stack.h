#ifndef STACK_H
#define STACK_H

template <typename T>
class Stack
{
    private:
        T* _head;
        int _count;
    public:
        Stack() 
        {
            _count = 0;
        }
        void Push(T* element)
        {
            _head = element;
            _count++;
        }
        T Pop()
        {
            T* poppedElement = _head;
            //Redirect head to next element if it exists
            return poppedElement;
        }
        int Count()
        {
            return _count;
        }
        void Clear()
        {
            _head = nullptr;
            _count = 0;
        }
};

#endif