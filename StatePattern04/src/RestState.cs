using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern04.src
{
    class RestState : IWorkState
    {
        public void WriteProgram(Work w)
        {
            Console.WriteLine($"当前时间：{w.CurrentHour}，下班回家啦，嘎嘎嘎。。");
        }
    }
}
