using System;
using System.Threading;

namespace HandTestCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("----Calculator App-----");
            Console.Write("Input the first number: ");
            double inputA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the second number: ");
            double inputB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("----Calculating-----");

            Thread.Sleep(1000);

            double result = calculator.Add(inputA,inputB);
            double result2 = calculator.Subtract(inputA, inputB);
            double result3 = calculator.Multiply(inputA, inputB);
            double result4 = calculator.Power(inputA, inputB);

            Console.WriteLine("Result of add: " + result);
            Console.WriteLine("Result of subtract: " + result2);
            Console.WriteLine("Result of Multiply: " + result3);
            Console.WriteLine("Result of Power: " + result4);
            Console.ReadLine();
        }
    }
}
