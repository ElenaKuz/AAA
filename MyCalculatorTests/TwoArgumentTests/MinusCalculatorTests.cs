using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    [TestFixture]
    public class MinusCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            // подготовительные действия
            ITwoArgumentsCalculator calcultor = new MinusCalculator();
            double actual = calcultor.Calculate(6, 2);
            Assert.AreEqual(4, actual);
        }
        // ...
    }

}
