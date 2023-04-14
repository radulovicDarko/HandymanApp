using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// HandymanAbility entity class
    /// </summary>
    [PrimaryKey("Id", "UserId", "WorkTypeId")]
    [Table("HandymanAbilities")]
    public class HandymanAbility : BaseEntity
    {
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
        public User User { get; set; } = null!;

        /// <summary>
        /// Gets or sets the work type foreign key
        /// </summary>
        public WorkType WorkType { get; set; } = null!;
    }
}
