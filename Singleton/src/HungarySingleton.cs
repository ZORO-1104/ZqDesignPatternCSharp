using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.src
{
    //sealed，阻止发生派生，而派生可能会增加实例
    sealed class HungarySingleton
    {
        //静态初始化方式
        private static readonly HungarySingleton singleton = new HungarySingleton();

        private HungarySingleton()
        {

        }

        public static HungarySingleton GetInstance()
        {
            return singleton;
        }
    }
}
