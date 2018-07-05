using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class CtanTests
    {
        [TestCase(1, 0.64209261593433065d)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new CtanCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}