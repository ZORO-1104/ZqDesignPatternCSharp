using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern04.src
{
    class SleepingState : IWorkState
    {
        public void WriteProgram(Work w)
        {
            Console.WriteLine($"当前时间{w.CurrentHour}，不行啦，要着了。。。。。。");
        }
    }
}
