﻿using WindowsFormsApp1.OneArgument;
using NUnit.Framework;

namespace MyCalculatorTests.OneArgumentTests
{
    [TestFixture]
    public class MinusXTests
    {
        [TestCase(-2, 2)]
        [TestCase(3, -3)]
        [TestCase(4, -4)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new MinusXCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }

}