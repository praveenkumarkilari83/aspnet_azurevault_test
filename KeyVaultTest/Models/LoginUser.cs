using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyVaultTest.Models
{
    [Table("login", Schema = "dbo")]
    public class LoginUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Username")]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        [Column("Password")]
        public string Password { get; set; }

        [Column("Email")]
        [StringLength(255)]
        public string Email { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Column("IsActive")]
        public bool IsActive { get; set; } = true;
    }
}