namespace WindowsFormsApp1.OneArgument
{
    public class PowCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return first * first;
        }
    }
}
