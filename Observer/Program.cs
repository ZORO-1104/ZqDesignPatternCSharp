using Observer.src;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractSubject sub1 = new Boss("胡汉三");
            IObserver obs1 = new BallColleague("张三");
            IObserver obs2 = new StockColleague("李四");

            sub1.Add(obs1);
            sub1.Add(obs2);
            sub1.Add(obs1);

            sub1.Notify();

            Console.ReadLine();
        }
    }
}
