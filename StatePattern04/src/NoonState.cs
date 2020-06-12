using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern04.src
{
    class NoonState : IWorkState
    {
        public void WriteProgram(Work w)
        {
            if (w.CurrentHour < 13)
            {
                Console.WriteLine($"当前时间：{w.CurrentHour}，饿了，午饭；犯困，午休！");
            }
            else
            {
                w.State = new AfternoonState();
                w.WriteProgram();
            }
        }
    }
}
