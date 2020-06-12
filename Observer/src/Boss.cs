using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.src
{
    class Boss : AbstractSubject
    {
        private string name;

        public Boss(string name)
        {
            this.name = name;
        }

        public override void Notify()
        {

            foreach (IObserver item in lstObserver)
            {
                item.Response();
                item.Response02("我"+ name+"回来啦~");
            }
        }

        //public override void Add(AbstractObserver abs)
        //{
        //    if (!lstObserver.Contains(abs))
        //    {
        //        lstObserver.Add(abs);
        //    }            
        //}

        //public override void Notify()
        //{
        //    foreach (AbstractObserver item in lstObserver)
        //    {
        //        item.Response();
        //    }
        //}

        //public override void Remove(AbstractObserver abs)
        //{
        //    if (lstObserver.Contains(abs))
        //    {
        //        lstObserver.Remove(abs);
        //    }
        //}
    }
}
