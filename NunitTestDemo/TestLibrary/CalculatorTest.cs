using NUnit.Framework;
using System;
using NunitTestDemo;

namespace TestLibrary
{
    [TestFixture]
    public class CalculatorTest
    {
        Calcultor cal;
        [SetUp]
        public void setup()
        {
            cal = new Calcultor();
        }

        [TearDown]
        public void TearDown()
        {
            cal.Dispose();
        }
        [Test,Order(2)]
        public void addition_Test()
        {
            var cal = new Calcultor();
             var result= cal.Addition(2, 3);
            Assert.AreEqual(5, result);
        }
        [TestCase(1,2,3)]
        [TestCase(2,3,5)]
        [TestCase(3,4,7)]
        public void addition_Test_Multipletestcase(int first, int second, int expectedresult)
        {
            var cal = new Calcultor();
            var result = cal.Addition(first,second);
            Assert.AreEqual(expectedresult, result);
        }

        [Test]
        [Ignore(" dummy method")]
        public void testMethod()
        {

        }
        [Test, Order(1)]
        public void test_subtraction()
        {
            var result = cal.subtraction(3, 2);
            Assert.AreEqual(1, result);
        }
    }
}
