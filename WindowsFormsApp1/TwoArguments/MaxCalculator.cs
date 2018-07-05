namespace WindowsFormsApp1.TwoArguments
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            
            return first > second ? first : second;
        }
    }
}
