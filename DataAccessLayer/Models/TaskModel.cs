﻿using System;
using Workshop.DataAccessLayer.Models.Dictionaries;

namespace Workshop.DataAccessLayer.Models
{

    public class TaskModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string BikeManufacturer { get; set; }
        public string BikeModel { get; set; }
        public string FrameNumber { get; set; }
        public string AdditionalInfo { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Cost { get; set; }
        public string TaskDescription { get; set; }

        public StatusModel Status { get; set; }
    }
}
