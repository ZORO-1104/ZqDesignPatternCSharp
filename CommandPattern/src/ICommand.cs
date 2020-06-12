using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.src
{
    interface ICommand
    {
        void ExecuteDefaultCmd();

        void ExecuteSpecificCmd(string cmdMsg);
    }
}
