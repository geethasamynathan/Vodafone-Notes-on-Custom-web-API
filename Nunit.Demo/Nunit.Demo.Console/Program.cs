using System;

namespace Nunit.Demo.Console
{
    public class Calculator
    {
        public int Addition(int first, int second)
        {
            return first + second;
        }

        public int Subtraction(int first, int second)
        {
            if (first < second)
                throw new ArgumentException($"First number {first} is less than second number {second}");

            return first - second;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Addition(4, 32);

        }
    }
}
