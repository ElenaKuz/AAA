using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class SredgeomCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            double multiply;
            multiply = first * second;
            if (multiply < 0)
            {
                throw new Exception("Меньше 0");
            }
            return Math.Sqrt(multiply);
        }
    }
}
