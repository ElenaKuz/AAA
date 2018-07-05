using System;

namespace WindowsFormsApp1.OneArgument
{
    public class ArccosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }

    }
}
