using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern.src
{
    class RealSubject : ISubject
    {
        public void Execute()
        {
            Console.WriteLine("RealSubject execute");
        }
    }
}
