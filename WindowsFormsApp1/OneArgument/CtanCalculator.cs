
using System;

namespace WindowsFormsApp1.OneArgument
{
    public class CtanCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            if (first == 0)
            {
                throw new Exception("Ctg 0 не сущ.");
            }
            return 1/Math.Tan(first);
        }

    }
}
