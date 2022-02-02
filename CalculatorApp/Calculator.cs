using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandTestCalculatorApp
{
    public class Calculator
    {
        private double _a;
        private double _b;
        private double _x;
        private double _exp;


        public Calculator()
        {
            _a = 0.0;
            _b = 0.0;
        }

        public double Add(double a, double b)
        {
            _a = a;
            _b = b;
            double result = a + b;

            return result;
        }

        public double Subtract(double a, double b)
        {
            _a = a;
            _b = b;
            double result = a - b;

            return result;
        }

        public double Multiply(double a, double b)
        {
            _a = a;
            _b = b;
            double result = a * b;

            return result;
        }

        public double Power(double x, double exp)
        {
            _x = x;
            _exp = exp;
            double result = Math.Pow(x, exp);

            return result;
        }


    }
}
