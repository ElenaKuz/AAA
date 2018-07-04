using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class PlusCalculatorTests
    {
        [TestCase(6, 2, 8)]
        [TestCase(8, 6, 14)]
        [TestCase(9, 3, 12)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new PlusCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}