using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;

        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();

        }

        public void PopulateGrid()
        {
            // Select a custom model collection of cars from database
            var cars = _db.TypesOfCars
                .Select(q => new
                {
                    Make = q.Make,
                    Model = q.Model,
                    VIN = q.VIN,
                    Year = q.Year,
                    LicensePlateNumber = q.LicensePlateNumber,
                    q.Id
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            //Hide the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            gvVehicleList.Columns["Id"].Visible = false;
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void btAddNewCar_Click(object sender, EventArgs e)
        {
            AddEditVehicle addEditVehicle = new AddEditVehicle();
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvVehicleList.SelectedRows.Count > 0) // Check if any row is selected
                {
                    var Id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
                    var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == Id);
                    AddEditVehicle addEditVehicle = new AddEditVehicle(car);
                    addEditVehicle.MdiParent = this.MdiParent;
                    addEditVehicle.Show();
                }
                else
                {
                    MessageBox.Show("Please select a vehicle first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btDeleteCar_Click(object sender, EventArgs e)
        {
            var Id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
            var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == Id);
            _db.TypesOfCars.Remove(car);     
            _db.SaveChanges();
            gvVehicleList.Refresh();

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gvVehicleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
