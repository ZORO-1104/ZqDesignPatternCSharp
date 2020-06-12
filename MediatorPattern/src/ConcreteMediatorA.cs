using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.src
{
    class ConcreteMediatorA : Mediator
    {
        public ConcreteMediatorA(string name) : base(name)
        {
        }

        public override void Register(Colleague colleague)
        {
            if (!_lstColleague.Contains(colleague))
            {
                _lstColleague.Add(colleague);
                colleague.SetMediator(this);
            }
        }

        public override void Relay(Colleague colleague, string msg)
        {
            foreach (var item in _lstColleague)
            {
                if (item!=colleague)
                {
                    item.ReceiveMsgInterface(msg);
                }
            }
        }
    }
}
