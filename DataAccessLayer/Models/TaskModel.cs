using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.DataAccessLayer.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Bike { get; set; }
        public string Tasks { get; set; }
        public string Status { get; set; }
        public decimal Cost { get; set; }
    }
}
