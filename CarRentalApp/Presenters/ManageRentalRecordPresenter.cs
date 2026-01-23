using CarRentalApp.Interfaces;
using CarRentalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Presenters
{

    public class ManageRentalRecordPresenter
    {
        private readonly IManageRentalRecordView _view;
        private readonly CarRentalEntities _db;


        public ManageRentalRecordPresenter(IManageRentalRecordView view)
        {
            _view = view;
            _db = new CarRentalEntities();

            // Subscribe to view events
            _view.ViewLoaded += OnViewLoaded;
            _view.AddRecordClicked += OnAddRecordClicked;
            _view.EditRecordClicked += OnEditRecordClicked;
            _view.DeleteRecordClicked += OnDeleteRecordClicked;
        }

        private void OnViewLoaded(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void OnAddRecordClicked(object sender, EventArgs e)
        {
            var addEditForm = new AddEditRentalRecord();
            _view.ShowChildForm(addEditForm);
        }

        private void OnEditRecordClicked(object sender, EventArgs e)
        {
            try
            {
                if (_view.SelectedRecordId.HasValue)
                {
                    var record = _db.CarRentalRecords
                        .FirstOrDefault(q => q.id == _view.SelectedRecordId.Value);
                    if (record != null)
                    {
                        var addEditForm = new AddEditRentalRecord(record);
                        _view.ShowChildForm(addEditForm);
                    }
                }
                else
                {
                    _view.ShowMessage("Please select a vehicle first.");
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error: {ex.Message}");
            }
        }

        private void OnDeleteRecordClicked(object sender, EventArgs e)
        {
            try
            {
                if (_view.SelectedRecordId.HasValue)
                {
                    var record = _db.CarRentalRecords
                        .FirstOrDefault(q => q.id == _view.SelectedRecordId.Value);
                    if (record != null)
                    {
                        _db.CarRentalRecords.Remove(record);
                        _db.SaveChanges();
                        LoadRecords();
                    }
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error: {ex.Message}");
            }
        }

        private void LoadRecords()
        {
            var records = _db.CarRentalRecords.Select(q => new CarRentalRecordDto
            {
                Customer = q.CustomerName,
                DateOut = (DateTime) q.DateRented,
                DateIn = (DateTime) q.DateRented,
                Id = q.id,
                Cost = (decimal) q.Cost,
                Car = q.TypesOfCar.Make + " " + q.TypesOfCar.Model
            }).ToList();

            _view.DisplayRecords(records);
        }

    }

}
