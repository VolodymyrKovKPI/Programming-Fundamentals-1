using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class AboutForm : Form
    {
        public AboutForm(MainWindow mainWindow)
        {
            InitializeComponent();
        }

        private void CloseWindowButton_Click(object sender, EventArgs e) =>
            Hide();
    }
}
