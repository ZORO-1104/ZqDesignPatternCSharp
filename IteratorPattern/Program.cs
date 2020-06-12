using IteratorPattern.src;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregateA ca1 = new ConcreteAggregateA();
            ca1.Add("zoro");
            ca1.Add("robin");
            ca1.Add("gween");
            ca1.Add("dido");

            Iterator it1 = ca1.GetIterator();

            while (it1.IsHaveNext())
            {
                Console.WriteLine(it1.Next().ToString());
            }

            Console.WriteLine("按任意键退出啦。。。");
            Console.ReadLine();
        }
    }
}
