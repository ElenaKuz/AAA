
namespace WindowsFormsApp1.TwoArguments
{
    public class MinusCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
