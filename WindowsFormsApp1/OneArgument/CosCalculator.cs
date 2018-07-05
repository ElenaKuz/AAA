using System;

namespace WindowsFormsApp1.OneArgument
{
    public class CosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }

    }
}
