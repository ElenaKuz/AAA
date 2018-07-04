namespace WindowsFormsApp1.OneArgument
{
    public class PowCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return first * first;
        }
    }
}
