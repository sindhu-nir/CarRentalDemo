using CarRentalApp.Interfaces;
using CarRentalApp.Models;
using CarRentalApp.Presenters;
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
    public partial class ManageRentalRecord : Form, IManageRentalRecordView
    {
        private readonly ManageRentalRecordPresenter _presenter;

        public int? SelectedRecordId
        {
            get
            {
                if (gvRecordList.SelectedRows.Count > 0)
                    return (int)gvRecordList.SelectedRows[0].Cells["Id"].Value;
                return null;
            }
        }
        public event EventHandler AddRecordClicked;
        public event EventHandler EditRecordClicked;
        public event EventHandler DeleteRecordClicked;
        public event EventHandler ViewLoaded;

        public ManageRentalRecord()
        {
            InitializeComponent();
            _presenter = new ManageRentalRecordPresenter(this);
        }

        public void ShowChildForm(Form childForm)
        {
            // Set MdiParent only if this form is inside an MDI container
            if (this.MdiParent != null)
            {
                childForm.MdiParent = this.MdiParent;
            }
            childForm.Show();
        }

        public void DisplayRecords(List<CarRentalRecordDto> records)
        {
            gvRecordList.DataSource = records;
            gvRecordList.Columns["DateIn"].HeaderText = "Date In";
            gvRecordList.Columns["DateOut"].HeaderText = "Date Out";
            gvRecordList.Columns["Id"].Visible = false;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btAddRecord_Click(object sender, EventArgs e) => AddRecordClicked?.Invoke(this, EventArgs.Empty);
        private void btEditRecord_Click(object sender, EventArgs e) => EditRecordClicked?.Invoke(this, EventArgs.Empty);
        private void btDeleteRecord_Click(object sender, EventArgs e) => DeleteRecordClicked?.Invoke(this, EventArgs.Empty);
        private void ManageRentalRecord_Load(object sender, EventArgs e) => ViewLoaded?.Invoke(this, EventArgs.Empty);
    }
}
