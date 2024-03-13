using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{

    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        [MaxLength(20)]
        public string PaymentMethod { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal AmountPaid { get; set; }
    }
}
