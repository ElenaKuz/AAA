using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class XgradeyCalculatorTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 8)]
        [TestCase(3, 2, 9)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new XgradeyCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}
