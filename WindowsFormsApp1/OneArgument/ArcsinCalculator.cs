using System;

namespace WindowsFormsApp1.OneArgument
{
     public class ArcsinCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Asin(first);
        }

    }
}

  