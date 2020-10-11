using System;
namespace MathCalculatorTests
{
    public class MathCalculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            return a/b;
        }

        public int Div(string a, string b)
        {
            return Convert.ToInt32(a) / Convert.ToInt32(b);
        }
    }
}
