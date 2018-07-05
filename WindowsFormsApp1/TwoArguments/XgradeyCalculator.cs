using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class XgradeyCalculator : ITwoArgumentsCalculator
   {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="first"></param>
       /// <param name="second"></param>
       /// <returns></returns>
       public double Calculate(double first, double second)
       {
           return Math.Pow(first, second);
       }
   }
}
