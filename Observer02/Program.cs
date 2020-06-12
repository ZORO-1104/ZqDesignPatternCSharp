using Observer02.src;
using System;

namespace Observer02
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss b1 = new Boss("胡汉三");

            StockColleague c1 = new StockColleague("张三");
            BallColleague c2 = new BallColleague("李四");

            b1.UpdateEventHandle += c1.CloseStockMarket;
            b1.UpdateEventHandle += c2.CloseBallDirectSeeding;
            b1.UpdateEventHandle += c1.CloseStockMarket;
            b1.UpdateEventHandle += c1.CloseStockMarket;
            b1.UpdateEventHandle += c1.CloseStockMarket;
            b1.UpdateEventHandle += c1.CloseStockMarket;
            b1.UpdateEventHandle -= c2.CloseBallDirectSeeding;

            b1.UpdateEventHandle02 += c2.CloseBallDirectSeeding;

            b1.Notify("我回来啦");

            Console.WriteLine("press any key quit ...");
            Console.ReadLine();
        }
    }
}
