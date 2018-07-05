using System;

namespace WindowsFormsApp1.OneArgument
{
    public class ArctgCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Atan(first);
        }

    }
}
