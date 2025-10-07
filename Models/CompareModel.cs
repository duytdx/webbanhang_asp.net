using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Tutorial.Models
{
    [Table("Compares")]
    public class CompareModel
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string UserId { get; set; }

        public ProductModel Product { get; set; }
    }
}