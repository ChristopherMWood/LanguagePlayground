#ifndef H_MOTHER
#define H_MOTHER

class Mother
{
    protected:
        char const * title;
        char const * name;
    public:
        Mother() {};
        Mother(char const * name) : name(name) { title = "Mother"; };
        char const * Name();
        char const * Title();
};

char const * Mother::Name()
{
    return this->name;
}

char const * Mother::Title()
{
    return this->title;
}

#endif