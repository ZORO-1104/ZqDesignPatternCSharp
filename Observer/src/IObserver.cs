using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.src
{
    interface IObserver
    {
         void Response();
        void Response02(string sendMsg);
    }
}
