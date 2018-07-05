using System;

namespace WindowsFormsApp1.OneArgument
{
    public class ModulCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }

    }
}
