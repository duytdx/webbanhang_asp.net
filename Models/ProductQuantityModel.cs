using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Tutorial.Models
{
    [Table("ProductQuantities")]
    public class ProductQuantityModel
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;

        public ProductModel Product { get; set; }
    }
}