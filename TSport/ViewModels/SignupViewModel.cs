using System.ComponentModel.DataAnnotations;

namespace TSport.ViewModels
{
    public class SignupViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(6,ErrorMessage ="Password must be atleast 6 characters!")]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Password and confirm password not mactch!")]
        public string ConfirmPass { get; set; }
    }
}
