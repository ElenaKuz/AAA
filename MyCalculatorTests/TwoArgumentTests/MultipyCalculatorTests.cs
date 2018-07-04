using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class MultipyCalculatorTests
    {
        [TestCase(3, 2, 6)]
        [TestCase(2, 4, 8)]
        [TestCase(3, 3, 9)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MultipyCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }

}
