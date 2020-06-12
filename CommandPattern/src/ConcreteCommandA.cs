using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.src
{
    class ConcreteCommandA : ICommand
    {
        private ReceiverA receiver;

        public ConcreteCommandA(ReceiverA  receiver)
        {
            this.receiver = receiver;
        }

        public void ExecuteDefaultCmd()
        {
            Console.WriteLine("具体命令类调用接受者执行命令。。。");
            receiver.ActionDefaultMethod();
        }

        public void ExecuteSpecificCmd(string cmdMsg)
        {
            receiver.ActionSpecificMethod(cmdMsg);
        }
    }
}
