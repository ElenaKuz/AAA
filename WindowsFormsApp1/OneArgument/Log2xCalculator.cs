using System;

namespace WindowsFormsApp1.OneArgument
{
    public class Log2XCalculator : IOneArgumentCalculator
    {
    public double Calculate(double first)
    {
        return Math.Log(2,first);
    }

    }
}