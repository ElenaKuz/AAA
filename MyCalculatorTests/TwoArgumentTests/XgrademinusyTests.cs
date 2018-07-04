using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class XgrademinusyTests
    {
        [TestCase(2, -2, 0.25)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new XgrademinusyCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}