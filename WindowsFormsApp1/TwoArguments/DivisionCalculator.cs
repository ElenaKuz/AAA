using System;

namespace WindowsFormsApp1.TwoArguments
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            
            if (second == 0)
            {
                throw new Exception("Деление на 0");
            }
            return first / second;
        }

    }
}
