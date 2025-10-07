using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Tutorial.Models
{
    [Table("Orders")]
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }

        public string OrderCode { get; set; }

        public string UserName { get; set; }

        public DateTime CreatedDate { get; set; }

        public int Status { get; set; }

        public string ShippingCost { get; set; }

        public string CouponCode { get; set; }
    }
}