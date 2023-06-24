using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassWraith.Data.Entities
{
    [Table("credential")]
    public class PasswordEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_name")]
        public string UserName { get; set; }

        [MaxLength]
        [Column("encrypted_password")]
        public string Password { get; set; }

        [Required]
        [Column("website_name")]
        public string WebSiteName { get; set; }

        [Url]
        [Column("website_url")]
        public string WebsiteSiteUrl { get; set; }

        [Url]
        [Column("website_icon_url")]
        public string WebSiteIconUrl { get; set; }

        [Column("card_number")]
        public string CardNumber { get; set; }

        [Column("pin")]
        public string PIN { get; set; }

        [Column("card_expiry_date")]
        public DateTime? CardExpiryDate { get; set; }

        [MaxLength]
        [Column("note")]
        public string Notes { get; set; }

        [Column("favourite")]
        public bool IsFavourite { get; set; } = false;

        [Column("delete")]
        public bool IsDeleted { get; set; } = false;

        [Column("credential_type")]
        public Type CredentialType { get; set; } = Type.Login;

        [Column("deleted_date")]
        public DateTime? DeletedDate { get; set; }

        [Column("creation_date")]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public enum Type
        {
            Login,
            Card,
            Identity
        }
    }
}
