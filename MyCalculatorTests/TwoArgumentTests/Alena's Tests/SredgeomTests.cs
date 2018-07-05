
using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class SredgeomTests
    {
        [TestCase(8, 2, 4)]
        [TestCase(32, 2, 8)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new SredgeomCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}