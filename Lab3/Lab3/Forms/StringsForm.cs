using System;
using System.Windows.Forms;

namespace Lab3.Forms
{
    public partial class StringsForm : Form
    {
        public StringsForm()
        {
            InitializeComponent();
        }

        private void WorkWithString()
        {
            string input = InputString.Text;

            if (input.EndsWith("World!"))
            {
                input.Split();
            }
            
            input.TrimStart(' ').Insert(5, "Ho-ho-ho").PadRight(3);

            OutputString.Text = input;
        }

        private void DoWork_Click(object sender, EventArgs e)
        {
            WorkWithString();
        }
    }
}
