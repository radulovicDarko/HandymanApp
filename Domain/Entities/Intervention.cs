using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Intervention entity class
    /// </summary>
    [PrimaryKey("Id", "UserId", "EventId")]
    [Table("Interventions")]
    public class Intervention : BaseEntity
    {
        /// <summary>
        /// Gets or sets the status
        /// </summary>
        [StringLength(50)]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the event id
        /// </summary>
        public string EventId { get; set; }

        /// <summary>
        /// Gets or sets the user foreign key
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the event foreign key
        /// </summary>
        public Event Event { get; set; }
    }
}
