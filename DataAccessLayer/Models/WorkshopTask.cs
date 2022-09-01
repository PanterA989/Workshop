using System;
using System.ComponentModel.DataAnnotations;
using Workshop.DataAccessLayer.Models.Dictionaries;

namespace Workshop.DataAccessLayer.Models
{

    public class WorkshopTask
    {
        public int Id { get; set; }

        [Required]
        public Client Client { get; set; }

        [Required]
        public Bike Bike { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal? Cost { get; set; }

        [Required]
        public string TaskDescription { get; set; }

        [Required]
        public WorkshopTaskStatus Status { get; set; }
    }
}
