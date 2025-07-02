using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsSdk
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Divider cannot be zero.");
            return a / b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double SquareRoot(double a)
        {
            if (a < 0)
                throw new ArgumentException("Cannot calculate square root of a negative number.");
            return Math.Sqrt(a);
        }

        public long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers.");

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
