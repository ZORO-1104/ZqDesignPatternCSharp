using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.src
{
    class FacadeSystem
    {
        private SubSystemA _subSystemA;
        private SubSystemB _subSystemB;
        private SubSystemC _subSystemC;
        private SubSystemD _subSystemD;

        public FacadeSystem()
        {
            _subSystemA = new SubSystemA();
            _subSystemB = new SubSystemB();
            _subSystemC = new SubSystemC();
            _subSystemD = new SubSystemD();
        }

        public void MethodA()
        {
            Console.WriteLine("FacadeSystem的方法A");
            _subSystemA.FunA();
            _subSystemB.FunB();
            _subSystemD.FunD();
        }

        public void MethodB()
        {
            Console.WriteLine("FacadeSystem的方法B");
            _subSystemB.FunB();
            _subSystemC.FunC();
        }
    }
}
