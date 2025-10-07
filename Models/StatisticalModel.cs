using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Tutorial.Models
{
    [Table("Statisticals")]
    public class StatisticalModel
    {
        [Key]
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int Sold { get; set; }

        public decimal Revenue { get; set; }

        public DateTime DateCreated { get; set; }

        // Properties for anonymous objects in dashboard
        [NotMapped]
        public string date { get; set; }
        
        [NotMapped]
        public decimal revenue { get; set; }
        
        [NotMapped]
        public int orders { get; set; }
    }
}