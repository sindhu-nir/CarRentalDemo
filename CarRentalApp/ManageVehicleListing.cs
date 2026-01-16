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

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            var cars = _db.TypesOfCars
                .Select(q => new {
                    q.Make,
                    q.Model, 
                    q.VIN, 
                    q.Year, 
                    q.LicensePlateNumber,
                    q.Id,
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            //gvVehicleList.Columns[0].HeaderText = "ID";
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;

        }

        private void btAddNewCar_Click(object sender, EventArgs e)
        {
            AddEditVehicle addEditVehicle = new AddEditVehicle();
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btEditCar_Click(object sender, EventArgs e)
        {
            var Id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
            var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == Id);
            AddEditVehicle addEditVehicle = new AddEditVehicle(car);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btDeleteCar_Click(object sender, EventArgs e)
        {
            var Id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
            var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == Id);
            _db.TypesOfCars.Remove(car);     
            _db.SaveChanges();
            gvVehicleList.Refresh();

        }
    }
}
