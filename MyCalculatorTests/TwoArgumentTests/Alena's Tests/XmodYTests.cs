using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class XmodYTests
    {
        [TestCase(4, 3, 1)]
        [TestCase(8, 5, 3)]
        [TestCase(8, 3, 2)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new XmodYCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}