using System.ComponentModel.DataAnnotations;

namespace HomeEase.ViewModels
{
    public class SignupViewModel
    {
        public InputModel Input { get; set; } = new();

        public class InputModel
        {
            [Required(ErrorMessage = "Please Enter Your Full Name.")]
            public string FullName { get; set; } = string.Empty;

            [Required(ErrorMessage = "Email is required.")]
            [EmailAddress(ErrorMessage = "Enter a valid email address.")]
            [Display(Name = "Email address")]
            public string Email { get; set; } = string.Empty;

            [Required(ErrorMessage = "Contact No. is required.")]
            [RegularExpression(
                @"^09\d{9}$",
                ErrorMessage = "Enter a valid 11-digit Philippine mobile number."
            )]
            public string ContactNumber { get; set; } = string.Empty;

            [Required(ErrorMessage = "Password is required.")]
            [DataType(DataType.Password)]
            public string Password { get; set; } = string.Empty;

            [Required(ErrorMessage = "Confirm Password is required.")]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "Passwords do not match.")]
            public string ConfirmPassword { get; set; } = string.Empty;
        }
    }
}