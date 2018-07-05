using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class XgrademinusyTests
    {
        [TestCase(4, 2, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new XgrademinusyCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}