
namespace WindowsFormsApp1
{
    public class MultipyCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
