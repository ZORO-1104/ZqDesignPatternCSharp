using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.src
{
    class DivideCalculator : AbstractCalculator
    {
        protected override double CalculateResult()
        {
            if (0!=_num2)
            {
                return _num1 / _num2;
            }
            else
            {
                throw new Exception("除数不能为0。");
            }
        }
    }
}
