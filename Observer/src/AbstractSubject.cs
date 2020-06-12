using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.src
{
    abstract class AbstractSubject
    {
        protected List<IObserver> lstObserver = new List<IObserver>();

        //public abstract void Add(IObserver abs);

        //public abstract void Remove(IObserver abs);

        public abstract void Notify();

        public void Add(IObserver abs)
        {
            if (!lstObserver.Contains(abs))
            {
                lstObserver.Add(abs);
            }
        }


        public void Remove(IObserver abs)
        {
            if (lstObserver.Contains(abs))
            {
                lstObserver.Remove(abs);
            }
        }
    }
}
