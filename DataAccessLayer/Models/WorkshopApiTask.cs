using System;

namespace Workshop.DataAccessLayer.Models
{
    /// <summary>
    /// Simplified representation of WorkshopTask
    /// </summary>
    public class WorkshopApiTask
    {
        public SimpleClient Client { get; set; }
        public SimpleBike Bike { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }
        public decimal? Cost { get; set; }
        public string TaskDescription { get; set; }
        public int StatusId { get; set; } = 1;
    }

    /// <summary>
    /// Simplified representation of Client
    /// </summary>
    public class SimpleClient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    /// <summary>
    /// Simplified representation of Bike
    /// </summary>
    public class SimpleBike
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string FrameNumber { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
