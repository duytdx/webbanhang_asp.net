using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Tutorial.Models
{
    [Table("Contacts")]
    public class ContactModel
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập tên")]
        public string Name { get; set; }

        [Required, EmailAddress, MinLength(4, ErrorMessage = "Yêu cầu nhập email")]
        public string Email { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập số điện thoại")]
        public string Phone { get; set; }

        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập nội dung")]
        public string Message { get; set; }

        public string Description { get; set; }

        public string LogoImg { get; set; }

        public string Map { get; set; }

        [NotMapped]
        [FileExtensions(Extensions = "jpg,jpeg,png,gif", ErrorMessage = "Chỉ chấp nhận file ảnh")]
        public IFormFile ImageUpload { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}