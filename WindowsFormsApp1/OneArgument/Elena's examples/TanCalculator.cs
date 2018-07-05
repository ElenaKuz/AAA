using System;

namespace WindowsFormsApp1.OneArgument
{
    public class TanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }

    }
}
