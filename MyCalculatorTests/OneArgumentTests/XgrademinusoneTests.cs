using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class XgrademinusoneTests
    {
        [TestCase(2, 0.5)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new XgrademinusoneCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}