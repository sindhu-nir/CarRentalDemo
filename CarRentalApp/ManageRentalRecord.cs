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
    public partial class ManageRentalRecord : Form
    {
        private readonly CarRentalEntities _db;
        public ManageRentalRecord()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btAddRecord_Click(object sender, EventArgs e)
        {
            var addRentalRecord = new AddEditRentalRecord
            {
                MdiParent = this.MdiParent
            };
            addRentalRecord.Show();
        }

        private void btEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvRecordList.SelectedRows.Count > 0) // Check if any row is selected
                {
                    var Id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
                    var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == Id);
                    var addEditRentalRecord = new AddEditRentalRecord(record);
                    addEditRentalRecord.MdiParent = this.MdiParent;
                    addEditRentalRecord.Show();
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

        private void btDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var Id = (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == Id);
                _db.CarRentalRecords.Remove(record);
                _db.SaveChanges();
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ManageRentalRecord_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PopulateGrid()
        {
            var records = _db.CarRentalRecords.Select(q => new
            {
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateRented,
                Id = q.id,
                Cost = q.Cost,
                Car = q.TypesOfCar.Make + " " + q.TypesOfCar.Model
            }).ToList();
            gvRecordList.DataSource = records;
            gvRecordList.Columns["DateIn"].HeaderText = "Date In";
            gvRecordList.Columns["DateOut"].HeaderText = "Date Out";
            //Hide the column for ID. Changed from the hard coded column value to the name, 
            // to make it more dynamic. 
            gvRecordList.Columns["Id"].Visible = false;
        }
    }
}
