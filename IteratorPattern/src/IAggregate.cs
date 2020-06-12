using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.src
{
    interface IAggregate
    {
        void Add(Object o);

        void Remove(Object o);

        Iterator GetIterator();
    }
}
