﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.src
{
    class SubstractCalculator : AbstractCalculator
    {
        protected override double CalculateResult()
        {
            return _num1 - _num2;
        }
    }
}
