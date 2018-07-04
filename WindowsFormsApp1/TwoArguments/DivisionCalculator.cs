namespace WindowsFormsApp1.TwoArguments
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first / second;
        }
        
    }
}
