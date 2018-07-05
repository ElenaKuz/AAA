using System;

namespace WindowsFormsApp1.OneArgument
{
    public class TengradeX : IOneArgumentCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Pow(10, first);
        }

    }
}
