
using System.ComponentModel.DataAnnotations;

namespace Workshop.DataAccessLayer.Models.Dictionaries
{
    public class WorkshopTaskStatus
    {
        public int Id { get; set; }

        /// <summary>
        /// String representation of status
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Value { get; set; }

        /// <summary>
        /// Indicates if positions with this status should be presented in active or finished tasks list
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Group of status
        /// </summary>
        [Required]
        public int StatusGroupNumber { get; set; }

        /// <summary>
        /// Place in order in status group
        /// </summary>
        [Required]
        public int StatusGroupNumberOrder { get; set; }
    }
}
