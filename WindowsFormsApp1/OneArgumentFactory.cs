using System;

namespace WindowsFormsApp1
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator createCalculate(string CalculatorName)
        {
            switch (CalculatorName)
            {
                case "Sin": return new SinCalculator();
                case "Cos": return new CosCalculator();
                case "Pow": return new PowCalculator();
                case "Log10": return new Log10Calculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
