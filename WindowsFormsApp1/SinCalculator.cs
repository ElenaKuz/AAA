using System;

namespace WindowsFormsApp1
{
    public class SinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }

    }
}
