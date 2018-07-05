using System;

namespace WindowsFormsApp1.OneArgument
{
    public class Log2XCalculator : IOneArgumentCalculator
    {
    public double Calculate(double first)
    {
        if (first < 0)
        {
            throw new Exception("Меньше 0");
        }
            return Math.Log(first,2);
    }
    }
}