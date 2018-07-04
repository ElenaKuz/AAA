
namespace WindowsFormsApp1.TwoArguments
{
    public class MultipyCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
