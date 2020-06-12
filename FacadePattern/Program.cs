using FacadePattern.src;
using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeSystem fs1 = new FacadeSystem();
            fs1.MethodA();
            fs1.MethodB();

            Console.ReadLine();
        }
    }
}
