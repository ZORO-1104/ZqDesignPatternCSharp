using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.src
{
    interface Iterator
    {
        Object First();

        Object Next();

        bool IsHaveNext();
    }
}
