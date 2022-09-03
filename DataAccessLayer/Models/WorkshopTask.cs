using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Workshop.DataAccessLayer.Models.Dictionaries;

namespace Workshop.DataAccessLayer.Models
{

    public class WorkshopTask
    {
        public int Id { get; set; }

        [Required] 
        public Client Client { get; set; } = new Client();

        [Required] 
        public Bike Bike { get; set; } = new Bike();

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal? Cost { get; set; }

        [Required]
        public string TaskDescription { get; set; }

        [Required] 
        public WorkshopTaskStatus Status { get; set; } = new WorkshopTaskStatus();

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [ForeignKey("Bike")]
        public int BikeId { get; set; }

        [ForeignKey("Status")]
        public int StatusId { get; set; }
    }
}
