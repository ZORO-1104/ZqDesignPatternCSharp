using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.src
{
    abstract class Colleague
    {
        protected string _name;
        protected Mediator _mediator;

        public Colleague(string name)
        {
            _name = name;
        }

        public void SetMediator(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void SendMsgInterface(string msg)
        {
            SendMsg(msg);
            _mediator.Relay(this, msg);
        }
        public abstract void ReceiveMsgInterface(string msg);
        protected abstract void SendMsg(string msg);
    }
}
