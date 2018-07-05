
namespace WindowsFormsApp1.TwoArguments
{
    public class XdivYCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return (int)(first / second);
        }
    }
}
