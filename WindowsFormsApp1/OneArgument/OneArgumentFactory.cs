using System;

namespace WindowsFormsApp1.OneArgument
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculate(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sin": return new SinCalculator();
                case "Cos": return new CosCalculator();
                case "Pow": return new PowCalculator();
                case "Log10": return new Log10Calculator();
                case "Xgrademinusone": return new XgrademinusoneCalculator();
                case "Log2x": return new Log2XCalculator();
                case "Twogradex": return new TwogradeX();
                case "Tengradex": return new TengradeX();
                case "Arcsin": return new ArcsinCalculator();
                case "Arccos": return new ArccosCalculator();
                case "Arctg": return new ArctgCalculator();
                case "Modul": return new ModulCalculator();
                case "MinusX": return new MinusXCalculator();
                case "Tan": return new TanCalculator();
                case "Ctan": return new CtanCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
