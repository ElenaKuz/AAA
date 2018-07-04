using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class Log10CalculatorTests
    {
        [TestCase(10, 1)]
        [TestCase(100, 2)]
        [TestCase(10000, 4)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Log10Calculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}
