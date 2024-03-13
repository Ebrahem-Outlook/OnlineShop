using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int QuantityAvailable { get; set; }

        [Required]
        [MaxLength(50)]
        public string Category { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
    }
}
