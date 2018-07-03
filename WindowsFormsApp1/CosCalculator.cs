using System;

namespace WindowsFormsApp1
{
    public class CosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }

    }
}
