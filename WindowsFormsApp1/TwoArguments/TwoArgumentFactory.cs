using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace WindowsFormsApp1.TwoArguments
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
                case "Divide": return new DivisionCalculator();
                case "Xgradey": return new XgradeyCalculator();
                case "Xgrademinusy": return new XgrademinusyCalculator();
                case "Logxy": return new LogxyCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
