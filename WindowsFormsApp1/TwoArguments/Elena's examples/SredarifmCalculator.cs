
namespace WindowsFormsApp1.TwoArguments
{
    public class SredarifmCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return (first + second)/2;
        }
    }
}
