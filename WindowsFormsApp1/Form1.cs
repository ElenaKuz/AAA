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
            double result;
            string firstValueText = textBox3.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string secondValueText = textBox4.Text;
            double secondValue = Convert.ToDouble(secondValueText);
           switch (((Button)sender).Name)
            {
                case "Add":
                    result = secondValue + firstValue;
                    break;
                case "Substract":
                    result = firstValue - secondValue;
                    break;
                case "Multiply":
                    result = firstValue * secondValue;
                    break;
                case "Divide":
                    result = firstValue / secondValue;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
            textBox5.Text = result.ToString();
        }
    }
}
