using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.src
{
    [Serializable]
    abstract class AbstractPerson
    {
        //深拷贝
        public abstract AbstractPerson DeepCopy();

        //浅拷贝
        public abstract AbstractPerson ShallowCopy();
    }
}
