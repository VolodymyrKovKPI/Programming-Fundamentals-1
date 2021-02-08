using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private double CalculateFormula(int x)
        {
            char b = 'b';
            
            var cos = Math.Cos(x * 7);
            
            var summandDividend1 = cos + x + Math.Exp(x+5);
            var summandDividend2 = Math.Log(3 * Math.Log(Math.Sqrt(2 * x + Math.Sin(x))));

            var summandDivider1 = Math.Exp(Math.Sin(x));
            var summandDivider2 = Math.Abs(2 * x + Math.Exp(2*x)) / Math.Tan(x);
            
            var dividend = summandDividend1 + summandDividend2;

            var divider = summandDivider1 + summandDivider2;

            var result = dividend / divider;

            return result;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InputTB.Text))
            {
                var x = int.Parse(InputTB.Text);

                var result = CalculateFormula(x);

                OutputTB.Text = result.ToString();
            }
        }
    }
}
