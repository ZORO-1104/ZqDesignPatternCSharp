using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.src
{
    class BallColleague : Colleague
    {
        public BallColleague(string name):base(name)
        {

        }

        public override void Response()
        {
            Console.WriteLine("{0}，不要看球赛了。。。", name);
        }

        public override void Response02(string sendMsg)
        {
            Console.WriteLine("【{0}】，{1}，不要看球赛了。。。", sendMsg, name);
        }
    }
}
