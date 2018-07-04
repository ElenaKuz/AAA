using System;

namespace WindowsFormsApp1.OneArgument
{
    public class CosCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }

    }
}
