using System;
using System.Collections.Generic;
using System.Text;

namespace Observer02.src
{
    class BallColleague : Colleague
    {
        public BallColleague(string name) : base(name)
        {
        }

        public void CloseBallDirectSeeding(string sendMsg)
        {
            Console.WriteLine("【{0}】，{1}，关闭球赛直播。。。", sendMsg, name);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
