using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern04.src
{
    class AfternoonState : IWorkState
    {
        public void WriteProgram(Work w)
        {
            if (w.CurrentHour < 17)
            {
                if (w.TaskFinished)
                {
                    Console.WriteLine($"当前时间：{w.CurrentHour}，工作已完成，很轻松的啦！");
                }
                else
                {
                    Console.WriteLine($"当前时间：{w.CurrentHour}，状态还不错，继续写程序！");
                }
            }
            else
            {
                w.State = new EveningState();
                w.WriteProgram();
            }
        }
    }
}
