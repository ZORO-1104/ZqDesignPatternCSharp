using StategyPattern.src;
using System;

namespace StategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyContext strategyContext1 = new StrategyContext();
            strategyContext1.SetStrategy(new CommonPersonStrategy());
            Console.WriteLine(strategyContext1.GetFinalPrice(10.1));

            StrategyContext strategyContext2 = new StrategyContext();
            strategyContext1.SetStrategy(new StudentStrategy());
            Console.WriteLine(strategyContext2.GetFinalPrice(10.1));

            StrategyContext strategyContext3 = new StrategyContext();
            strategyContext1.SetStrategy(new OldPersonStrategy());
            Console.WriteLine(strategyContext3.GetFinalPrice(10.1));

            #region 简单工厂与策略模式的结合

            //StrategyContext strategyContext1 = new StrategyContext(PersonEnum.Common);
            //Console.WriteLine(strategyContext1.GetFinalPrice(10.1));

            //StrategyContext strategyContext2 = new StrategyContext(PersonEnum.Student);
            //Console.WriteLine(strategyContext2.GetFinalPrice(10.1));

            //StrategyContext strategyContext3 = new StrategyContext(PersonEnum.OldMen);
            //Console.WriteLine(strategyContext3.GetFinalPrice(10.1));

            //Console.WriteLine(new StrategyContext(PersonEnum.Common).GetFinalPrice(20.1));
            //Console.WriteLine(new StrategyContext(PersonEnum.Student).GetFinalPrice(20.1));
            //Console.WriteLine(new StrategyContext(PersonEnum.OldMen).GetFinalPrice(20.1));
            #endregion

            Console.ReadLine();
        }
    }
}
