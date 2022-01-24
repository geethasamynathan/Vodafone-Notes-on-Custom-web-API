using NUnit.Framework;
using System;
using Nunit.Demo.Console;

namespace Nunit.Demo.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Test_Addition_with_valid_Integers()
        {
            var calc = new Calculator();
            var result = calc.Addition(3, 5);
            Assert.AreEqual(8, result);

        }
    }
}
