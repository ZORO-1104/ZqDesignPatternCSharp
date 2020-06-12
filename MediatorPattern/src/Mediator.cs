using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MediatorPattern.src
{
    abstract class Mediator
    {
        protected List<Colleague> _lstColleague;
        protected string _name;

        public string Name
        {
            get => _name;
        }

        public Mediator(string name)
        {
            _name = name;
            _lstColleague = new List<Colleague>();
        }

        public abstract void Register(Colleague colleague);
        public abstract void Relay(Colleague colleague, string msg);
    }
}
