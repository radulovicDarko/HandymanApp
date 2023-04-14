using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// WorkType entity class
    /// </summary>
    [Table("WorkTypes")]
    public class WorkType : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the abilities
        /// </summary>
        public List<HandymanAbility> Abilities { get; } = new();
    }
}
