
using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class ArccosCalculatorTests
    {
        [TestCase(1, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArccosCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}