using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
