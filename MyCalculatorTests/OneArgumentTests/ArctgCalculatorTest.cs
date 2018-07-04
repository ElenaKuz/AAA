
using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class ArctgCalculatorTest
    {
        [TestCase(0, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArctgCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}
