namespace WindowsFormsApp1.TwoArguments
{
    public class XdivYCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return (int)(first / second);
        }
    }
}
