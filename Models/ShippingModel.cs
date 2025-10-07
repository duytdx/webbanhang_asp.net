using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Tutorial.Models
{
    [Table("Shippings")]
    public class ShippingModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập phương thức vận chuyển")]
        public string Method { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string Ward { get; set; }

        public int Status { get; set; }
    }
}