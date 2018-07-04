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
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentFactory.createCalculate(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
