using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Tutorial.Models
{
    [Table("Coupons")]
    public class CouponModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập tên mã giảm giá")]
        public string Name { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập mô tả")]
        public string Description { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateExpired { get; set; }

        public int Quantity { get; set; }

        public int Status { get; set; }
    }
}