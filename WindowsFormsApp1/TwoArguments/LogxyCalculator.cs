using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class LogxyCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            if (first < 0)
            {
                throw new Exception("Меньше 0");
            }
            if (first == 1)
            {
                throw new Exception("Не равно 1");
            }
            if (second < 0)
            {
                throw new Exception("Меньше 0");
            }
            return Math.Log(second, first);
        }
    }
}