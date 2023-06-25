using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassWraith.Data.Entities
{
    [Table("user_password")]
    public class UserPasswordEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [MaxLength]
        [Column("encrypted_password")]
        [Required]
        public string Password { get; set; }
    }
}
