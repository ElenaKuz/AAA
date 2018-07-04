using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class MinusCalculatorTests
    {
        [TestCase(6, 2, 4)]
        [TestCase(8, 6, 2)]
        [TestCase(9, 3, 6)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MinusCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}
