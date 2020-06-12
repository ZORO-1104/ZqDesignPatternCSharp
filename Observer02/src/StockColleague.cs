using System;
using System.Collections.Generic;
using System.Text;

namespace Observer02.src
{
    class StockColleague : Colleague
    {
        public StockColleague(string name) : base(name)
        {

        }

        public void CloseStockMarket(string sendMsg)
        {
            Console.WriteLine("【{0}】，{1}，关闭股市风云。。。", sendMsg, name);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
