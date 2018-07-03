namespace WindowsFormsApp1
{
    public class PowCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return first * first;
        }
    }
}
