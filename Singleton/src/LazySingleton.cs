using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.src
{
    class LazySingleton
    {
        private static LazySingleton singleton;
        private static object syncRoot = new object();
        
        private LazySingleton()
        {
            Console.WriteLine("产生一个新的美国总统");
        }

        public static LazySingleton GetInstance()
        {
            //双重锁定Double-Check Locking
            //防止实例化多个实例

            /*
            当singleton为null时，如果同时多个线程调用GetInstance方法，
            那么这些线程都会通过第1重的null==singleton判断，
            然后由于lock的机制，这些线程将逐个执行lock内的语句，
            此时如果没有第2重的singleton是否为null的判断，
            那么在第一个线程创建的实例后，后续的线程还是可以继续再创建新的实例，
            这就没有达到单例的目的
            */

            if (null==singleton)
            {
                lock (syncRoot)
                {
                    if (null==singleton)
                    {
                        singleton = new LazySingleton();
                    }
                    else
                    {
                        Console.WriteLine("已存在美国总统，不能再产生新的了。。。");
                    }
                }
            }
            else
            {
                Console.WriteLine("已存在美国总统，不能再产生新的了。。。");
            }

            return singleton;
        }

        public void Show()
        {
            Console.WriteLine("我是美国总统：奥巴马");
        }

    }
}
