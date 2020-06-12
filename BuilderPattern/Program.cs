using BuilderPattern.src;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBuilder build_1 = new ConcreteBuilderA();
            BuildDirector director_1 = new BuildDirector(build_1);
            Product p_1 = null;

            p_1 = director_1.ConstructProduct();
            p_1.Show();

            AbstractBuilder build_2 = new ConcreteBuilderB();
            BuildDirector director_2 = new BuildDirector(build_2);

            p_1 = director_2.ConstructProduct();
            p_1.Show();

            Console.ReadLine();
        }
    }
}
