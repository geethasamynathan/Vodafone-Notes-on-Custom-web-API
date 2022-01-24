using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Main.Test.BusinessLogic
{
    public class MathBL
    {
        public int Sum(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        public int Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int Subtraction(int num1, int num2)
        {
            if (num1 < num2)
                throw new ArgumentException($"First number {num1} less than {num2}.");
            int sum = num1 + num2;
            return sum;
        }
    }
}
