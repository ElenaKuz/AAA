using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class XgradeyCalculator : ITwoArgumentsCalculator
   {
       public double Calculate(double first, double second)
       {
           return Math.Pow(first, second);
       }
   }
}
