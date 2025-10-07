using System.ComponentModel.DataAnnotations;

namespace Shopping_Tutorial.Models.ViewModels
{
    public class LoginViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Password"), MinLength(4, ErrorMessage = "Password có ít nhất 4 ký tự")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}