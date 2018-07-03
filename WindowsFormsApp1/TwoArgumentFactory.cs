using System;

namespace WindowsFormsApp1
{
    public static class TwoArgumentFactory
    {
        public static ITwoArgumentsCalculator createCalculate(string CalculatorName)
        {
            switch (CalculatorName)
            {
                case "Add": return new PlusCalculator();
                case "Substract": return new MinusCalculator();
                case "Multiply":return new MultipyCalculator();
                case "Divide":return new DivisionCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
