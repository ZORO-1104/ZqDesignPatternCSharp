﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.src
{
    class SubtractOperation : AbstractOperation
    {
        protected override double CalculateResult()
        {
            return num1 - num2;
        }

        protected override string OperationType()
        {
            return "-";
        }
    }
}
