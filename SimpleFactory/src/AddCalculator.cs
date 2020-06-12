using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.src
{
    class AddCalculator : AbstractCalculator
    {
        protected override double CalculateResult()
        {
            return _num1 + _num2;
        }
    }
}
