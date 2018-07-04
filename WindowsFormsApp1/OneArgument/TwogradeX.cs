using System;

namespace WindowsFormsApp1.OneArgument
{
   public class TwogradeX : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(2, first);
        }

    }
}
 