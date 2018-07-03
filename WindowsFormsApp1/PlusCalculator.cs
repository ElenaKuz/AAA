namespace WindowsFormsApp1
{
    public class PlusCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
