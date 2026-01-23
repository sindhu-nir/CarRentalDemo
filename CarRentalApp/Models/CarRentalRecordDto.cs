using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp.Models
{
    // DTO for the grid (decoupled from EF)
    public class CarRentalRecordDto
    {
        public string Customer { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public string Car { get; set; }
    }
}
