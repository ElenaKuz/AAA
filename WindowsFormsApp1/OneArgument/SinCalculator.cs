using System;

namespace WindowsFormsApp1.OneArgument
{
    public class SinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }

    }
}
