using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;
using System;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class LogxyTest
    {
        [TestCase(2, 16, 4)]
        [TestCase(3, 27, 3)]
        [TestCase(4, 16, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new LogxyCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void MyCalculateTest1()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentFactory.createCalculate("Logxy");
            Assert.Throws<Exception>(() => calculator.Calculate(1, 2));
        }
        [Test]
        public void MyCalculateTest2()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentFactory.createCalculate("Logxy");
            Assert.Throws<Exception>(() => calculator.Calculate(-1, 3));
        }
        [Test]
        public void MyCalculateTest3()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentFactory.createCalculate("Logxy");
            Assert.Throws<Exception>(() => calculator.Calculate(2, -9));
        }
    }
}