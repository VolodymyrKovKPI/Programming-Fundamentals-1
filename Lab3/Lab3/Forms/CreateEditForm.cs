using System;
using System.Windows.Forms;

namespace Lab3.Forms
{
    public partial class CreateEditForm : Form
    {
        public CreateEditForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e) //UNDONE moq message
        {
            MessageBox.Show("Дані збережені!");
        }
    }
}
