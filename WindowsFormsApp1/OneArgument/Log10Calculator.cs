using System;

namespace WindowsFormsApp1.OneArgument
{
    public class Log10Calculator : IOneArgumentCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            if(first<0)
            {
                throw new Exception("Меньше 0");
            }
            return Math.Log10(first);
        }
    }
}
