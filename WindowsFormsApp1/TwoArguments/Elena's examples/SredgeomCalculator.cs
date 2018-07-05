using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class SredgeomCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Sqrt(first * second);
        }
    }
}
