using System;
using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests
{
    class OneArgumentFactoryTests
    {
        [TestCase("Sin", typeof(SinCalculator))]
        [TestCase("Cos", typeof(CosCalculator))]
        [TestCase("Pow", typeof(PowCalculator))]
        [TestCase("Log10", typeof(Log10Calculator))]
        [TestCase("Pow", typeof(PowCalculator))]
        [TestCase("Pow", typeof(PowCalculator))]
        [TestCase("Pow", typeof(PowCalculator))]
        [TestCase("Pow", typeof(PowCalculator))]
        [TestCase("Pow", typeof(PowCalculator))]
        [TestCase("Pow", typeof(PowCalculator))]
        [TestCase("Arctg", typeof(ArctgCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.createCalculate(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
