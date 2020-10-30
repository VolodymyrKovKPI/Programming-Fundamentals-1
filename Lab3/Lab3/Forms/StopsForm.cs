using System.Windows.Forms;

namespace Lab3
{
    public partial class StopsForm : Form
    {
        private readonly MainWindow _mainWindow;
        public StopsForm(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void BackToMainButton_Click(object sender, System.EventArgs e)
        {
            Hide();
            _mainWindow.Show();
        }
    }
}
