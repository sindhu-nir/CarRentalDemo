using CarRentalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarRentalApp.Interfaces
{
    public interface IManageRentalRecordView
    {
        // Events for the user actions
        event EventHandler AddRecordClicked;
        event EventHandler EditRecordClicked;
        event EventHandler DeleteRecordClicked;
        event EventHandler ViewLoaded;

        // Properties for selected record
        int? SelectedRecordId { get; }

        // Methods to manipulate UI
        void ShowChildForm(Form childForm); // Presenter tells view to open child form

        void DisplayRecords(List<CarRentalRecordDto> records);
        void ShowMessage(string message);
    }



}
