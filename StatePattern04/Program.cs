using StatePattern04.src;
using System;

namespace StatePattern04
{
    class Program
    {
        static void Main(string[] args)
        {
            //紧急项目
            Work w = new Work();
            //w.CurrentHour = 8;
            w.WriteProgram();
            w.CurrentHour = 9;
            w.WriteProgram();
            w.CurrentHour = 10;
            w.WriteProgram();
            w.CurrentHour = 11;
            w.WriteProgram();
            w.CurrentHour = 12;
            w.WriteProgram();
            w.CurrentHour = 13;
            w.WriteProgram();
            w.CurrentHour = 14;
            w.TaskFinished = true;
            w.WriteProgram();
            w.CurrentHour = 15;
            w.WriteProgram();
            w.CurrentHour = 16;
            w.WriteProgram();
            w.CurrentHour = 17;
            w.WriteProgram();
            w.CurrentHour = 18;
            w.WriteProgram();
            w.CurrentHour = 19;
            w.WriteProgram();
            w.CurrentHour = 20;
            w.WriteProgram();
            w.CurrentHour = 21;
            w.WriteProgram();
            w.CurrentHour = 22;
            w.WriteProgram();
            w.CurrentHour = 23;
            w.WriteProgram();
            w.CurrentHour = 24;
            w.WriteProgram();

            Console.ReadLine();
        }
    }
}
