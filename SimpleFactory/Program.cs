using SimpleFactory.src;
using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main()
        {
            AbstractCalculator abs1 = CalculatorFactory.GenerateCalculator(OperatorEnum.Add);
            abs1._num1 = 10.5;
            abs1._num2 = 20.2;
            Console.WriteLine(abs1.CalculateDispose());

            AbstractCalculator abs2 = CalculatorFactory.GenerateCalculator(OperatorEnum.Substract);
            abs2._num1 = 10.5;
            abs2._num2 = 20.2;
            Console.WriteLine(abs2.CalculateDispose());

            AbstractCalculator abs3 = CalculatorFactory.GenerateCalculator(OperatorEnum.Multiply);
            abs3._num1 = 10.5;
            abs3._num2 = 20.2;
            Console.WriteLine(abs3.CalculateDispose());

            AbstractCalculator abs4 = CalculatorFactory.GenerateCalculator(OperatorEnum.Divide);
            abs4._num1 = 10.5;
            abs4._num2 = 20.2;
            Console.WriteLine(abs4.CalculateDispose());

            Console.ReadLine();
        }
    }
}
