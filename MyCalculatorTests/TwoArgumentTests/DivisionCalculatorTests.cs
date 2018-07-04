using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [TestCase(6, 2, 3)]
        [TestCase(8, 4, 2)]
        [TestCase(9, 3, 3)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new DivisionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}
