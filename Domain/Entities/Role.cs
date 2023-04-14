using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Role entity class
    /// </summary>
    [Table("Roles")]
    public class Role : BaseEntity
    {
        [StringLength(50)]
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        ///Gets or sets the users
        /// </summary>
        public ICollection<User> Users { get; set; }
    }
}
