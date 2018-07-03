namespace WindowsFormsApp1
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double first, double second)
        {
            return first / second;
        }
        
    }
}
