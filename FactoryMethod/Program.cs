using FactoryMethod.src;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory ft1 = null;
            AbstractOperation op1 = null;

            //ft1 = new AddFactory();
            ft1 = new SubtractFactory();
            op1 = ft1.CreateProductOperation();
            op1.num1 = 10.1;
            op1.num2 = 20.5;
            Console.WriteLine(op1.ShowResult());

            //ft1 = new SubtractFactory();
            //op1 = ft1.CreateProductOperation();
            //op1.num1 = 100.6;
            //op1.num2 = 20.4;
            //Console.WriteLine(op1.ShowResult());

            Console.ReadLine();
        }
    }
}
