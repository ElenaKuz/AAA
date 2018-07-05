
using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            double max;
            if (first > second)
            { max = first;}
            else { max = second;}
            return max;
        }
    }
}
