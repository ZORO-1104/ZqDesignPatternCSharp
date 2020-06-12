using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.src
{
    class Invoker
    {
        private ICommand command = null;

        public Invoker(ICommand cmd)
        {
            command = cmd;
        }

        public void SetCommand(ICommand cmd)
        {
            command = cmd;
        }

        public void CallDefaultCmd()
        {
            Console.WriteLine("调用者调用命令方法。。。");
            command.ExecuteDefaultCmd();
        }

        public void CallSpecificCmd(string cmdMsg)
        {
            Console.WriteLine("调用者调用命令方法。。。");
            command.ExecuteSpecificCmd(cmdMsg);
        }
    }
}
