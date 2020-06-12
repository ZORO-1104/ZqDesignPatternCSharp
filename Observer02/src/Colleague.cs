using System;
using System.Collections.Generic;
using System.Text;

namespace Observer02.src
{
    abstract class Colleague
    {
        protected string name;

        public Colleague(string name)
        {
            this.name = name;
        }
    }
}
