using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class SinCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            // подготовительные действия
            IOneArgumentCalculator calcultor = new SinCalculator();
            double actual = calcultor.Calculate(0);
            Assert.AreEqual(0, actual);
        }
        // ...
    }

}
