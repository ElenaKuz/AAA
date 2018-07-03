
namespace WindowsFormsApp1
{
    public class MinusCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
