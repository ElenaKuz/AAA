using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class TwogradeXTests
    {
        [TestCase(2, 4)]
        [TestCase(3, 8)]
        [TestCase(4, 16)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new TwogradeX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}