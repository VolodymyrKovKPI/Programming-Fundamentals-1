using System;
using System.Windows.Forms;

namespace Lab3.Forms
{
    public partial class CastsForm : Form
    {
        public CastsForm()
        {
            InitializeComponent();
        }

        private void UlongToFloat()
        {
            if (InputBoxUlong.Text.Length > 0 && ulong.TryParse(InputBoxUlong.Text, out ulong operand))
            {
                float output = operand;
                OutputFloatBox.Text = (output).ToString();
            }
        }

        private void FloatToSbyte()
        {
            if (InputBoxFloat.Text.Length > 0 && float.TryParse(InputBoxFloat.Text, out float operand))
            {
                OutputSbyteBox.Text = ((sbyte)operand).ToString();
            }
        }

        private void ConvertHardCodedStaff()
        {
            object[] staff = {Convert.ToBoolean(1), Convert.ToByte(255), Convert.ToDecimal(21.34f), Convert.ToInt16(54) };

            foreach (var item in staff)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void DoItButton_Click(object sender, EventArgs e)
        {
            UlongToFloat();
            FloatToSbyte();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            ConvertHardCodedStaff();
        }
    }
}
