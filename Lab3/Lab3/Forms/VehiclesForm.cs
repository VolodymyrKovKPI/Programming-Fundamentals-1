using System.Windows.Forms;

namespace Lab3
{
    public partial class VehiclesForm : Form
    {
        private readonly MainWindow _mainWindow;
        public VehiclesForm(MainWindow mainWindow)
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
