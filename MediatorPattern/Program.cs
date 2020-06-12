using MediatorPattern.src;
using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator m1 = new ConcreteMediatorA("班委会");
            Colleague ca1 = new ConcreteColleagueA("张三");
            Colleague ca2 = new ConcreteColleagueA("李四");
            Colleague ca3 = new ConcreteColleagueA("赵五");
            Colleague cb1 = new ConcreteColleagueB("王六");
            Colleague cb2 = new ConcreteColleagueB("李斯");
            Colleague cb3 = new ConcreteColleagueB("王翦");

            m1.Register(ca1);
            m1.Register(ca2);
            m1.Register(ca3);
            m1.Register(cb1);
            m1.Register(cb2);
            m1.Register(cb3);
            //c1.SetMediator(m1);
            //c2.SetMediator(m1);

            ca1.SendMsgInterface("大家好，我是张三，幸会。。。");
            Console.WriteLine("------------");
            cb3.SendMsgInterface("你好，我叫王翦，是个军事战略家，谁不服就打谁。。。");

            Console.ReadLine();
        }
    }
}
