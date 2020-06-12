using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.src
{
    abstract class AbstractCalculator
    {
        public double _num1;
        public double _num2;

        protected abstract double CalculateResult();

        public double CalculateDispose()
        {
            return Math.Round(CalculateResult(), 5);
        }
    }
}
