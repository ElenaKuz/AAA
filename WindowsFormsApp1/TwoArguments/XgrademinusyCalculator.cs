using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class XgrademinusyCalculator: ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, (1/second));
        }
    }
}
