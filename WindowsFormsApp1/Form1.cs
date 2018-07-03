using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Click(object sender, EventArgs e)
        {
            string Transmission =((Button)sender).Name;
            string firstValueText = textBox3.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox4.Text;
            double secondValue = Convert.ToDouble(secondValueText);

            ITwoArgumentsCalculator calculator = TwoArgumentFactory.createCalculate(Transmission);
            double result = calculator.Calculate(firstValue, secondValue);
      
            textBox5.Text = result.ToString();
        }
    }
}
