
using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class ArcsinCalculatorTests
    {
        [TestCase(0, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArcsinCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}