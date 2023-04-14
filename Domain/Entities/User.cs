using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// User entity class
    /// </summary>
    [Table("Users")]
    public class User : BaseEntity
    {
        /// <summary>
        /// Gets or sets the username
        /// </summary>
        [StringLength(50)]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the username
        /// </summary>
        [StringLength(50)]
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the username
        /// </summary>
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the role id
        /// </summary>
        public string RoleId{ get; set; }

        /// <summary>
        /// Gets or sets the username
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Gets or sets the abilities
        /// </summary>
        public List<HandymanAbility> Abilities { get; } = new();

        /// <summary>
        /// Gets or sets the interventions
        /// </summary>
        public List<Intervention> Interventions { get; } = new();
    }
}
