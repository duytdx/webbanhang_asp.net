using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Tutorial.Models
{
    [Table("Sliders")]
    public class SliderModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập tên slider")]
        public string Name { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập mô tả slider")]
        public string Description { get; set; }

        public int Status { get; set; }

        public string Image { get; set; }

        [NotMapped]
        [FileExtensions(Extensions = "jpg,jpeg,png,gif", ErrorMessage = "Chỉ chấp nhận file ảnh")]
        public IFormFile ImageUpload { get; set; }
    }
}