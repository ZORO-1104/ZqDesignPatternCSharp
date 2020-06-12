using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Observer02.src
{
    //定义委托
    delegate void MyDelegate(string str);

    class Boss
    {
        private string name;
        public event MyDelegate UpdateEventHandle;
        public event Action<string> UpdateEventHandle02;

        public Boss(string name)
        {
            this.name = name;
        }

        public void Notify(string msg)
        {
            //string str = name + "，" + msg;
            UpdateEventHandle?.Invoke(name + "，" + msg);
            UpdateEventHandle02?.Invoke(">>>" + name + "，" + msg);


            //UpdateEventHandle?.BeginInvoke(str, null, null);
            //UpdateEventHandle02?.BeginInvoke(str, null, null);
        }
    }
}
