using System;

namespace Workshop.DataAccessLayer.Models
{
    public class WorkshopApiTask
    {
        public AddedClient Client { get; set; }
        public AddedBike Bike { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }
        public decimal? Cost { get; set; }
        public string TaskDescription { get; set; }
        public int StatusId { get; set; } = 1;
    }

    public class AddedClient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class AddedBike
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string FrameNumber { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
