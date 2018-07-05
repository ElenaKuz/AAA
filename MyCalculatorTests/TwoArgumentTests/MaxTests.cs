using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class MaxTests
    {
        [TestCase(4, 2, 4)]
        [TestCase(8, 5, 8)]
        [TestCase(3, 9, 9)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MaxCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}