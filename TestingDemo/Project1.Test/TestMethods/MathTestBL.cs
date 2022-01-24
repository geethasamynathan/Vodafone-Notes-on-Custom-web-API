using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Main.Test.BusinessLogic;

namespace Project1.Test.TestMethods
{
    [TestFixture]
    class MathTestBL
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void TestSum()
        {
            var mathBL = new MathBL();
            int result = mathBL.Sum(2, 3);
           // Assert.IsTrue(result == 5);
            Assert.AreEqual(5, result);
        }
        //[Test]
        //[Ignore("ignore test attribute used")]
        //public void sample()
        //{

        //}

        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 4, 7)]
        public void Test_Addition_Multiple(int first, int second, int expectedresult)
        {
            var calc = new MathBL();
            var calculated = calc.Addition(first, second);
            Assert.AreEqual(expectedresult, calculated);
        }
        [Test]
        public void Test_Substraction_Argument_Exception()
        {
            var calc = new MathBL();
            Assert.Catch<SystemException>(() => calc.Subtraction(4, 5));
            Assert.Throws<ArgumentException>(() => calc.Subtraction(4, 5));
        }

    }
}
