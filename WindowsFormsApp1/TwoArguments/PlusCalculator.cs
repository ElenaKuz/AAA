namespace WindowsFormsApp1.TwoArguments
{
    public class PlusCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
