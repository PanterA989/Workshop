using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.DataAccessLayer.ViewModel
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        public string BikeManufacturer { get; set; }
        public string BikeModel { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
    }
}
