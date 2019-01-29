#include "Mother.h"

class Daughter : public Mother
{
    public:
        Daughter(char const * name) : Mother(name) { this->title = "Daughter"; };
};