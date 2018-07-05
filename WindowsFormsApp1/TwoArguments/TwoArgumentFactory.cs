using System;

namespace WindowsFormsApp1.TwoArguments
{
    public static class TwoArgumentFactory
    {
        public static object CreateCalculate;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CalculatorName"></param>
        /// <returns></returns>

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
                case "Sredarifm": return new SredarifmCalculator();
                case "Sredgeom": return new SredgeomCalculator();
                case "Max": return new MaxCalculator();
                case "Min": return new MinCalculator();
                case "XmodY": return new XmodYCalculator();
                case "XdivY": return new XdivYCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
