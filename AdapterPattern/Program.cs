using AdapterPattern.src;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new ForwardPlayer("zoro");
            p1.Attack();

            Player p2 = new CenterPlayer("luffy");
            p2.Attack();
            p2.Defend();

            Player p3 = new GuardPlayer("robin");
            p3.Attack();

            Player p4 = new AdapterTranslator("姚明");
            p4.Attack();

            Console.ReadLine();
        }
    }
}
