using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.src
{
    class ConcreteIteratorA : Iterator
    {
        private List<Object> lstObject = new List<object>();
        private int index = -1;

        public ConcreteIteratorA(List<Object> lstObj)
        {
            lstObject = lstObj;

            index = -1;
        }

        public object First()
        {
            if (lstObject.Count!=0)
            {
                index = 0;
                return lstObject[index];
            }
            else
            {
                return null;
            }
        }

        public bool IsHaveNext()
        {
            if (index < lstObject.Count-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Next()
        {
            if (IsHaveNext())
            {
                return lstObject[++index];
            }
            else
            {
                return null;
            }
        }
    }
}
