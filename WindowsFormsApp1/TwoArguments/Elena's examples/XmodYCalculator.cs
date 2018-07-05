using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class XmodYCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return (first % second);
        }
    }
}
