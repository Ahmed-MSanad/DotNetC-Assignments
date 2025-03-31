using System.ComponentModel.DataAnnotations;

namespace Company.Web.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Format For Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_])(?!.*(.).*\1.*\1).{6,}$", 
                                  ErrorMessage = "Password must be at least 6 characters long, contain at least one uppercase letter, one lowercase letter, one digit, one special character, and have at least two unique characters.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword is required")]
        [Compare(nameof(Password), ErrorMessage = "ConfirmPassword doesn't match password !!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Required to Agree")]
        public bool isAgree { get; set; }
    }
}
