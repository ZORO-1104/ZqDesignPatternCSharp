using ProxySubject02.src;
using System;

namespace ProxySubject02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProxyPattern02 mp = new MyProxyPattern02();
            mp.Execute();
        }
    }
}
