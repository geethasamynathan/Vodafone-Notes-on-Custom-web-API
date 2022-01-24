using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NunitTestDemo
{
    public class Calcultor:Icalculator
    {
        public int Addition(int first,int second)
        {
            return first + second;
        }
        public int subtraction(int first, int second)
        {
            if (first < second)
                throw new ArgumentException($" first number {first} is less than {second}");
            return first - second;
        }
        public void Dispose()
        {

        }
    }
}
