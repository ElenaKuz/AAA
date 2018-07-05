using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class MinTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(8, 5, 5)]
        [TestCase(3, 9, 3)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MinCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}