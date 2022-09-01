using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.DataAccessLayer.Models
{
    public class Bike
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Manufacturer { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [MaxLength(50)]
        public string FrameNumber { get; set; }

        public string AdditionalInfo { get; set; }
    }
}
