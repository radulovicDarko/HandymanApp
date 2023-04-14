using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    /// <summary>
    /// Member entity class
    /// </summary>
    [Table("Members")]
    public class Member : BaseEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the surname
        /// </summary>
        [StringLength(100)]
        public string Surname { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the address
        /// </summary>
        [StringLength(100)]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the phone number
        /// </summary>
        [StringLength(50)]
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the jmbg
        /// </summary>
        [StringLength(13)]
        public string Jmbg { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the user id foreign key
        /// </summary>
        [ForeignKey("userFk")]
        public User User { get; set; }
    }
}
