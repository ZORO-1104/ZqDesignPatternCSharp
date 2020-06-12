using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern04.src
{
    class ForenoonState : IWorkState
    {
        public void WriteProgram(Work w)
        {
            if (w.CurrentHour<12)
            {
                Console.WriteLine($"当前时间：{w.CurrentHour}，工作精神百倍！");
            }
            else
            {
                w.State = new NoonState();
                w.WriteProgram();
            }
        }
    }
}
