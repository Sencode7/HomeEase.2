
    // ViewModels/LoginViewModels.cs
    using System.ComponentModel.DataAnnotations;

    namespace HomeEase.ViewModels
    {
        public class LoginViewModels
        {
            // This nested "Input" property is what the view binds to via asp-for="Input.Email" etc.
            // Similar to how you'd nest form fields under a single $request->validate([...]) group in Laravel,
            // except here the shape is explicit and strongly typed.
            public InputModel Input { get; set; } = new();

            // Optional: where to redirect after a successful login,
            // similar to session('url.intended') / redirect()->intended() in Laravel.
            public string? ReturnUrl { get; set; }

            public class InputModel
            {
                [Required(ErrorMessage = "Email is required.")]
                [EmailAddress(ErrorMessage = "Enter a valid email address.")]
                [Display(Name = "Email address")]
                public string Email { get; set; } = string.Empty;

                [Required(ErrorMessage = "Password is required.")]
                [DataType(DataType.Password)]
                public string Password { get; set; } = string.Empty;

                [Display(Name = "Remember me")]
                public bool RememberMe { get; set; }
            }
        }
    }