using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Tutorial.Models
{
    public class AppUserModel : IdentityUser
    {
        [Display(Name = "Username")]
        [NotMapped]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [NotMapped]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
        
        public string RoleId { get; set; }

        [NotMapped]
        public string Token { get; set; }
    }
}