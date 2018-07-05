using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class TengradeXTests
    {
        [TestCase(2, 100)]
        [TestCase(3, 1000)]
        [TestCase(4, 10000)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new TengradeX();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}