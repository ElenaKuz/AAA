using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class XgrademinusyCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, 1 / second);
        }
    }
}
