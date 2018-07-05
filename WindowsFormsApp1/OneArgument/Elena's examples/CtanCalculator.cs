
using System;

namespace WindowsFormsApp1.OneArgument
{
    public class CtanCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return 1/Math.Tan(first);
        }

    }
}
