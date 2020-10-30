using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Lab3.Forms;
using Lab3.Models;

namespace Lab3
{
    public partial class VehicleTypeForm : Form
    {
        private readonly MainWindow _mainWindow;
        private List<Vehicle> _vehicles;
        public VehicleTypeForm(MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
            FillVehicleList();
            UpdateGrid();
        }

        private void FillVehicleList() //HACK to dodge serialization/ORM coding
        {
            _vehicles = new List<Vehicle>()
            {
                new Vehicle("Bus", 80),
                new Vehicle("Car", 120)
            };
        }

        private void UpdateGrid()
        {
            if (_vehicles != null)
            {
                var table = new DataTable("Vehicles!");

                var vehicleName = new DataColumn("Тип");
                var vehicleSpeed = new DataColumn("Швидкість");

                table.Columns.Add(vehicleName);
                table.Columns.Add(vehicleSpeed);

                foreach (Vehicle vehicle in _vehicles)
                {
                    DataRow row = table.NewRow();
                    row["Тип"] = vehicle.VehicleType;
                    row["Швидкість"] = vehicle.MaxSpeed;

                    table.Rows.Add(row);
                }

                dataGridView1.DataSource = table;
            }
        }

        private void BackToMain_Click(object sender, System.EventArgs e)
        {
            _mainWindow.Show();
            Hide();
        }

        private void CreateForm_Click(object sender, System.EventArgs e)
        {
            new CreateEditForm().Show();
        }

        private void EditForm_Click(object sender, System.EventArgs e)
        {
            new CreateEditForm().Show();
        }
    }
}
