using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.src
{
    class ReceiverA
    {
        private string name;

        public ReceiverA(string name)
        {
            this.name = name;
        }

        public void ActionDefaultMethod()
        {
            Console.WriteLine("接收者执行命令。。。");
            Console.WriteLine("【A】命令接受者<{0}>，执行默认命令", name);
        }

        public void ActionSpecificMethod(string cmdMsg)
        {
            Console.WriteLine("【A】命令接受者<{0}>，执行<{1}>命令", name, cmdMsg);
        }
    }
}
