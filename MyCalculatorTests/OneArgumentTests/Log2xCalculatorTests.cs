using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorTests.OneArgumentTests
{
    class Log2xCalculatorTests
    {
    }
}

using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class ArctgCalculatorTest
    {
        [TestCase(0, 1)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArctgCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}
