using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.src
{
    class ConcreteIteratorB : Iterator
    {
        private List<Object> lstObject = new List<object>();
        private int index = -1;

        public ConcreteIteratorB(List<Object> lstObj)
        {
            lstObject = lstObj;

            index = lstObject.Count;
        }

        public object First()
        {
            if (lstObject.Count != 0)
            {
                index = lstObject.Count-1;
                return lstObject[index];
            }
            else
            {
                return null;
            }
        }

        public bool IsHaveNext()
        {
            if (index > 0)
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
                return lstObject[--index];
            }
            else
            {
                return null;
            }
        }
    }
}
