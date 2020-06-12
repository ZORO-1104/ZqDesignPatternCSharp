using ProxyPattern.src;
using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxySubject proxySubject = new ProxySubject(new RealSubject());
            proxySubject.Execute();

            Console.ReadLine();
        }
    }
}
