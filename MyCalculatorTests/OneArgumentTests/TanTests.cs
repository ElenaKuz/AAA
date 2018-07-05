using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class TanTests
    {
        [TestCase(0, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new TanCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}