using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            // подготовительные действия
            ITwoArgumentsCalculator calcultor = new DivisionCalculator();
            double actual = calcultor.Calculate(8, 2);
            Assert.AreEqual(4, actual);
        }
        // ...
    }

}
