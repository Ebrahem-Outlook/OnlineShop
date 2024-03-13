using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal TotalAmount { get; set; }

        [Required]
        [MaxLength(20)]
        public string OrderStatus { get; set; }
    }
}
