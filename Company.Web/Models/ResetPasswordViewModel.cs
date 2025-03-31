using System.ComponentModel.DataAnnotations;

namespace Company.Web.Models
{
    public class ResetPasswordViewModel
    {
        public string Email { get; set; }
        public string Token { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_])(?!.*(.).*\1.*\1).{6,}$",
                                  ErrorMessage = "Password must be at least 6 characters long, contain at least one uppercase letter, one lowercase letter, one digit, one special character, and have at least two unique characters.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword is required")]
        [Compare(nameof(Password), ErrorMessage = "ConfirmPassword doesn't match password !!")]
        public string ConfirmPassword { get; set; }
    }
}
