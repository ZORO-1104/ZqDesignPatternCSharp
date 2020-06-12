using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.src
{
    class ConcreteAggregateA : IAggregate
    {
        private List<Object> lstObject = new List<Object>();

        public void Add(object o)
        {
            lstObject.Add(o);
        }

        public Iterator GetIterator()
        {
            //return new ConcreteIteratorA(lstObject);
            return new ConcreteIteratorB(lstObject);
        }

        public void Remove(object o)
        {
            lstObject.Remove(o);
        }
    }
}
