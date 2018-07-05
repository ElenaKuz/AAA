using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class XdivYTests
    {
        [TestCase(4, 3, 1)]
        [TestCase(8, 5, 1)]
        [TestCase(8, 3, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new XdivYCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}