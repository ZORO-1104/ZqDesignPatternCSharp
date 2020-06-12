using AbstractFactory.src;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            src.AbstractFactory abf = null;
            AbstractAnimal aba = null;
            AbstractPlant abp = null;

            #region 抽象工厂模式
            Console.WriteLine("抽象工厂");

            //实际客户端中，该实例化代码，会有很多处（要不都是FarmA，要不都是FarmB）
            //一旦需要修改，会需要修改很多地方，这是不好的，丑陋的啦
            //所以需要结合简单工厂，将所有的实例化的地方归到一处
            //abf = new FarmFactoryA();
            abf = new FarmFactoryB();

            aba = abf.CreateAnimal();
            abp = abf.CreatePlant();

            aba.Eat();
            abp.PourWater();
            #endregion

            #region 抽象工厂+简单工厂
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("抽象工厂+简单工厂");
            FarmSimpleFactory fsf = new FarmSimpleFactory();
            aba = fsf.CreateAnimal();
            abp = fsf.CreatePlant();

            aba.Eat();
            abp.PourWater();
            #endregion

            #region 抽象工厂+简单工厂+反射
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("抽象工厂+简单工厂+反射");
            FarmSimpleFactoryReflection fsff = new FarmSimpleFactoryReflection();
            aba = fsff.CreateAnimal();
            abp = fsff.CreatePlant();

            aba.Eat();
            abp.PourWater();
            #endregion

            #region 抽象工厂+简单工厂+反射+XML配置文件
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("抽象工厂+简单工厂+反射+XML配置文件");
            FarmSimpleFactoryReflectionConfigureFile fsffcf = new FarmSimpleFactoryReflectionConfigureFile();
            aba = fsffcf.CreateAnimal();
            abp = fsffcf.CreatePlant();

            aba.Eat();
            abp.PourWater();
            #endregion

            Console.ReadLine();

        }
    }
}
