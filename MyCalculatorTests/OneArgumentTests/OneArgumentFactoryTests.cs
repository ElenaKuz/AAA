using System;
using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    class OneArgumentFactoryTests
    {
        [TestCase("Sin", typeof(SinCalculator))]
        [TestCase("Cos", typeof(CosCalculator))]
        [TestCase("Pow", typeof(PowCalculator))]
        [TestCase("Log10", typeof(Log10Calculator))]
        [TestCase("Xgrademinusone", typeof(XgrademinusoneCalculator))]
        [TestCase("Log2x", typeof(Log2XCalculator))]
        [TestCase("Twogradex", typeof(TwogradeX))]
        [TestCase("Tengradex", typeof(TengradeX))]
        [TestCase("Arcsin", typeof(ArcsinCalculator))]
        [TestCase("Arccos", typeof(ArccosCalculator))]
        [TestCase("Arctg", typeof(ArctgCalculator))]
        [TestCase("Modul", typeof(ModulCalculator))]
        [TestCase("MinusX", typeof(MinusXCalculator))]
        [TestCase("Tan", typeof(TanCalculator))]
        [TestCase("Ctan", typeof(CtanCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculate(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
