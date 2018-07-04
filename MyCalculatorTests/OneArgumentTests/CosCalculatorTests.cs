using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class CosCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            // подготовительные действия
            IOneArgumentCalculator calcultor = new CosCalculator();
            double actual = calcultor.Calculate(0);
            Assert.AreEqual(1, actual);
        }
        // ...
    }

}
