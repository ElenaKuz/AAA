using System;

namespace WindowsFormsApp1.OneArgument
{
    public class TwogradeX : IOneArgumentCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Pow(2, first);
        }
    }
}
