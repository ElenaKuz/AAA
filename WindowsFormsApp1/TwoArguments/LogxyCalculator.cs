using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class LogxyCalculator : ITwoArgumentsCalculator
        {
            public double Calculate(double first, double second)
            {
                return Math.Log(first,second);
            }
        }
    }