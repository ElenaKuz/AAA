using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class MultipyCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            // подготовительные действия
            ITwoArgumentsCalculator calcultor = new MultipyCalculator();
            double actual = calcultor.Calculate(2, 2);
            Assert.AreEqual(4, actual);
        }
        // ...
    }

}
