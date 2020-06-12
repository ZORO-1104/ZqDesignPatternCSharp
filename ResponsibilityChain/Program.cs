using ResponsibilityChain.src;
using System;

namespace ResponsibilityChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Request r1 = new Request();
            Manager m1 = new TeamLeader("章邯");
            Manager m2 = new Director("王翦");
            Manager m3 = new Boss("嬴政");
            m1.SetSuperior(m2);
            m2.SetSuperior(m3);

            r1.Type = QuestionType.Leave;
            r1.Description = "小菜请事假";
            r1.Num = 1;
            m1.HandleRequest(r1);

            r1.Type = QuestionType.Leave;
            r1.Description = "小菜请事假";
            r1.Num = 3;
            m1.HandleRequest(r1);

            r1.Type = QuestionType.Salary;
            r1.Description = "小菜请调薪";
            r1.Num = 1500;
            m1.HandleRequest(r1);

            Console.ReadLine();
        }
    }
}
