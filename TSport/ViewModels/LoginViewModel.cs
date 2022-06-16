using System.ComponentModel.DataAnnotations;

namespace TSport.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage ="Email invalid!")]
        public string Email { get; set; }
        [Required]
        [MinLength(6,ErrorMessage ="Password must be atleast 6 characters!")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
