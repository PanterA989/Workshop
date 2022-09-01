
using System.ComponentModel.DataAnnotations;

namespace Workshop.DataAccessLayer.Models.Dictionaries
{
    public class WorkshopTaskStatus
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Value { get; set; }
    }
}
