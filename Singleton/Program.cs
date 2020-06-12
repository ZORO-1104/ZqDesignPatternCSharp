using Singleton.src;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            LazySingleton ls1 = LazySingleton.GetInstance();
            ls1.Show();
            LazySingleton ls2 = LazySingleton.GetInstance();
            ls2.Show();
            LazySingleton ls3 = LazySingleton.GetInstance();
            ls3.Show();

            Console.ReadLine();
        }
    }
}
