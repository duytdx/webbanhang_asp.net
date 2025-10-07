using System.ComponentModel.DataAnnotations;

namespace Shopping_Tutorial.Models.ViewModels
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Email"), EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Password"), MinLength(4, ErrorMessage = "Password có ít nhất 4 ký tự")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Password"), MinLength(4, ErrorMessage = "Password có ít nhất 4 ký tự")]
        public string PasswordConfirm { get; set; }
    }
}