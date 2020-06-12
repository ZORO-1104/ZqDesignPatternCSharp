using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern04.src
{
    class EveningState : IWorkState
    {
        public void WriteProgram(Work w)
        {
            if (w.TaskFinished)
            {
                w.State = new RestState();
                w.WriteProgram();
            }
            else
            {
                if (w.CurrentHour < 21)
                {
                    Console.WriteLine($"当前时间：{w.CurrentHour}，加班的啦，疲惫至极！");
                }
                else
                {
                    w.State = new SleepingState();
                    w.WriteProgram();
                }
            }

        }
    }
}
