using System;

namespace WindowsFormsApp1.OneArgument
{
    public class ArccosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Acos(first);
        }
    }
}
