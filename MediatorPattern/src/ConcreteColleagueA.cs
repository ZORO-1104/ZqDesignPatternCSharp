using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.src
{
    class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(string name) : base(name)
        {
        }

        public override void ReceiveMsgInterface(string msg)
        {
            Console.WriteLine($"{this.GetType().Name}类>>{_name}，从{_mediator.Name}接收到消息：{msg}");
        }

        protected override void SendMsg(string msg)
        {
            Console.WriteLine($"{this.GetType().Name}类>>{_name}，经{_mediator.Name}发出消息：{msg}");
        }
    }
}
