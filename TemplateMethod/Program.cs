using System;
using TemplateMethod.src;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMakeFoodTemplate absA = new ConcreteMakeFoodA();
            absA.MakeFood();

            AbstractMakeFoodTemplate absB = new ConcreteMakeFoodB();
            absB.MakeFood();

            Console.ReadLine();
        }
    }
}
