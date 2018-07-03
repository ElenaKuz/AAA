using System;

namespace WindowsFormsApp1
{
    public class Log10Calculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Log10(first);
        }
    }
}
