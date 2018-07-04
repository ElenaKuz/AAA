using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class Log10CalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            // подготовительные действия
            IOneArgumentCalculator calcultor = new Log10Calculator();
            double actual = calcultor.Calculate(100);
            Assert.AreEqual(2, actual);
        }
        // ...
    }

}
