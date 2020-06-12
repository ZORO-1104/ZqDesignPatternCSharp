using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.src
{
    abstract class Colleague : IObserver
    {
        protected string name;

        public Colleague(string name)
        {
            this.name = name;
        }

        public abstract void Response();
        public abstract void Response02(string sendMsg);
    }
}
