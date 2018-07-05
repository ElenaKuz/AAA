using System;
using WindowsFormsApp1.TwoArguments;
using NUnit.Framework;

namespace MyCalculatorTests.TwoArgumentTests
{
    public class TwoArgumentsFactoryTests
    {

        [TestCase("Add", typeof(PlusCalculator))]
        [TestCase("Substract", typeof(MinusCalculator))]
        [TestCase("Multiply", typeof(MultipyCalculator))]
        [TestCase("Divide", typeof(DivisionCalculator))]
        [TestCase("Xgradey", typeof(XgradeyCalculator))]
        [TestCase("Xgrademinusy", typeof(XgrademinusyCalculator))]
        [TestCase("Logxy", typeof(LogxyCalculator))]
        [TestCase("Sredarifm", typeof(SredarifmCalculator))]
        [TestCase("Sredgeom", typeof(SredgeomCalculator))]
        [TestCase("Max", typeof(MaxCalculator))]
        [TestCase("Min", typeof(MinCalculator))]
        [TestCase("XmodY", typeof(XmodYCalculator))]
        [TestCase("XdivY", typeof(XdivYCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentFactory.createCalculate(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
