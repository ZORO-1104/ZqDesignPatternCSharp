using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.src
{
    class CalculatorFactory
    {
        public static AbstractCalculator GenerateCalculator(OperatorEnum operatorEnum)
        {
            AbstractCalculator _abstractCalculator = null;

            switch (operatorEnum)
            {
                case OperatorEnum.Add:
                    _abstractCalculator = new AddCalculator();
                    break;
                case OperatorEnum.Substract:
                    _abstractCalculator = new SubstractCalculator();
                    break;
                case OperatorEnum.Multiply:
                    _abstractCalculator = new MultiplyCalculator();
                    break;
                case OperatorEnum.Divide:
                    _abstractCalculator = new DivideCalculator();
                    break;
                default:
                    _abstractCalculator = new AddCalculator();
                    break;
            }

            return _abstractCalculator;
        }
    }
}
