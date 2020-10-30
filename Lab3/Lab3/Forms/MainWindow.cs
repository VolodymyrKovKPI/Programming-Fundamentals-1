using System.Windows.Forms;
using Lab3.Forms;

namespace Lab3
{
    public partial class MainWindow : Form
    {
        private readonly AboutForm _aboutForm;
        private readonly VehicleTypeForm _vehicleTypeForm;
        private readonly RoutesForm _routesForm;
        private readonly StopsForm _stopsForm;
        private readonly VehiclesForm _vehiclesForm;
        private readonly CastsForm _castsForm;
        private readonly StringsForm _stringsForm;

        public MainWindow()
        {
            InitializeComponent();

            _aboutForm = new AboutForm(this);
            _routesForm = new RoutesForm(this);
            _stopsForm = new StopsForm(this);
            _vehiclesForm = new VehiclesForm(this);
            _vehicleTypeForm = new VehicleTypeForm(this);
            _castsForm = new CastsForm();
            _stringsForm = new StringsForm();
        }

        private void AboutMenuItem_Click(object sender, System.EventArgs e) => 
            _aboutForm.Show();

        private void quitToolStripMenuItem_Click(object sender, System.EventArgs e) => 
            Application.Exit();

        private void vehiclesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            _vehicleTypeForm.Show();
        }

        private void RoutesMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            _routesForm.Show();
        }

        private void StopsMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            _stopsForm.Show();
        }

        private void GarageMenuItem_Click(object sender, System.EventArgs e)
        {
            Hide();
            _vehiclesForm.Show();
        }

        private void CastsMenuItem_Click(object sender, System.EventArgs e) => 
            _castsForm.Show();

        private void StringsMenuItem_Click(object sender, System.EventArgs e) => 
            _stringsForm.Show();
    }
}
