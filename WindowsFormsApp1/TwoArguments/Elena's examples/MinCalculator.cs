
using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class MinCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            double min;
            if (first > second)
            { min = second; }
            else { min = first; }
            return min;
        }
    }
}