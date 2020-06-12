using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.src
{
    //抽象产品类
    abstract class AbstractOperation
    {
        public double num1;
        public double num2;

        public string ShowResult()
        {
            return num1 + OperationType() + num2 + "=" + Math.Round(CalculateResult(), 5);
        }

        protected abstract double CalculateResult();

        protected abstract string OperationType();
    }
}
