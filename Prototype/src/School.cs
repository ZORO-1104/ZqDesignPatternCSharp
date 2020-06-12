using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.src
{
    [Serializable]
    class School
    {
        public string name;
        public string address;

        public School()
        {

        }

        public School(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
