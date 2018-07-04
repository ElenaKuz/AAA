using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class PowCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            // подготовительные действия
            IOneArgumentCalculator calcultor = new PowCalculator();
            double actual = calcultor.Calculate(2);
            Assert.AreEqual(4, actual);
        }
        // ...
    }

}