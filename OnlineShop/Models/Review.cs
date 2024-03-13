using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{

    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        public string Comment { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }
    }
}
