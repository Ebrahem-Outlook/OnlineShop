using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        public DateTime LastLogin { get; set; }
    }   
}
