using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Event entity class
    /// </summary>
    [Table("Events")]
    public class Event : BaseEntity
    {
        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user id
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the work type id
        /// </summary>
        public string WorkTypeId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user foreign key
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the work type foreign key
        /// </summary>
        public WorkType WorkType{ get; set; }

        /// <summary>
        /// Gets or sets the interventions
        /// </summary>
        public List<Intervention> Interventions { get; } = new();
    }
}
