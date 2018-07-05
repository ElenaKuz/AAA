using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class SredarifmTests
    {
        [TestCase(4, 6, 5)]
        [TestCase(5, 7, 6)]
        [TestCase(3, 5, 4)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new SredarifmCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}