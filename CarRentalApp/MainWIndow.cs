using CarRentalApp.Utils;
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
    public partial class MainWIndow : Form
    {
        private Login _login;
        public string _RoleName;
        public MainWIndow()
        {
            InitializeComponent();
        }

        public MainWIndow(Login login, string roleShortName)
        {
            InitializeComponent();
            _login = login;
            _RoleName = roleShortName;
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.Utils.FormOpen("AddEditRentalRecord"))
            {
                var addRentalRecord = new AddEditRentalRecord();
                addRentalRecord.MdiParent = this;
                addRentalRecord.Show();
            }

        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!Utils.Utils.FormOpen("ManageVehicleListing"))
            {
                var vehicleListing = new ManageVehicleListing();
                vehicleListing.MdiParent = this;
                vehicleListing.Show();
            }
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRentalRecords = new ManageRentalRecord();
            manageRentalRecords.MdiParent = this;
            manageRentalRecords.Show();
        }

        private void MainWIndow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void managerUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.Utils.FormOpen("ManageUsers"))
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show();
            }
        }

        private void MainWIndow_Load(object sender, EventArgs e)
        {
            if (_RoleName != "Admin")
            {
                managerUsersToolStripMenuItem.Visible = false;
            }
        }
    }
}
