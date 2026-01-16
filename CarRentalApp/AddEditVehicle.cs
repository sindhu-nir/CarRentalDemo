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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities _db;

        public AddEditVehicle()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vehicle";
            isEditMode = false;
            _db = new CarRentalEntities();
        }

        public AddEditVehicle(TypesOfCar carToEdit) 
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vehicle";
            PopulateFields(carToEdit);
            isEditMode = true;
            _db = new CarRentalEntities();
        }

        private void PopulateFields(TypesOfCar car)
        {
            lblId.Text = car.Id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbVIN.Text = car.VIN;
            tbYear.Text = car.Year.ToString();
            tbLicenseNo.Text = car.LicensePlateNumber;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                var id = int.Parse(lblId.Text);
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                car.Model = tbModel.Text;
                car.Make = tbMake.Text;
                car.VIN = tbVIN.Text;
                car.Year = int.Parse(tbYear.Text);
                car.LicensePlateNumber = tbLicenseNo.Text;
                _db.SaveChanges();
            }
            else
            {
                var car = new TypesOfCar
                {
                    LicensePlateNumber = tbLicenseNo.Text,
                    Make = tbMake.Text,
                    Model = tbModel.Text,
                    VIN = tbVIN.Text,
                    Year = int.Parse(tbYear.Text)
                };
                _db.TypesOfCars.Add(car);
                _db.SaveChanges();

            }
        }   

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
