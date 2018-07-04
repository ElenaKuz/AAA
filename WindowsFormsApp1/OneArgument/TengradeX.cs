using System;

namespace WindowsFormsApp1.OneArgument
{
    public class TengradeX : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(10, first);
        }

    }
}
