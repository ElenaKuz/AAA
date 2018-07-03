using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                case "Plus":
                    result = secondValue + firstValue;
                    break;
                case "Minus":
                    result = firstValue - secondValue;
                    break;
                case "Multiplication":
                    result = firstValue * secondValue;
                    break;
                case "Division":
                    result = firstValue / secondValue;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
            textBox5.Text = result.ToString();
        }
    }
}
