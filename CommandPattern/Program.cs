using CommandPattern.src;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ReceiverA rec1 = new ReceiverA("烤肉串张师傅");
            ICommand cmd1 = new ConcreteCommandA(rec1);
            Invoker er1 = new Invoker(cmd1);

            er1.CallDefaultCmd();
            //er1.CallSpecificCmd("烤10把羊肉串");

            Console.ReadLine();
        }
    }
}
