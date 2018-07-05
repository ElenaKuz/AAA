using System;
using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class Log2XCalculatorTests
    {
        [TestCase(4, 2)]
        [TestCase(16, 4)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Log2XCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void MyCalculateTest()
        {
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculate("Log2x");
            Assert.Throws<Exception>(() => calculator.Calculate(-3));
        }
    }
}
