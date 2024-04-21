using AspNetCore_MVC.Filters;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore_MVC.ViewModels;

public class SignUpViewModel
{

    [Required(ErrorMessage ="Enter a first name")]
    [Display(Name = "First name", Prompt = "Enter your first name")]
    [MinLength(2,ErrorMessage ="Enter a first name")]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "Enter a last name")]
    [Display(Name = "Last name", Prompt = "Enter your last name")]
    [MinLength(2, ErrorMessage = "Enter a last name")]
    public string LastName { get; set; } = null!;

    [Required(ErrorMessage = "Enter your email address")]
    [Display(Name = "E-mail address", Prompt = "Enter your e-mail address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Enter your password")]
    [Display(Name = "Password", Prompt = "Enter your password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Required(ErrorMessage = "Password must be confirmed")]
    [Display(Name = "Confirm Password", Prompt = "Confirm your password")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Passwords do not match")]
    public string ConfirmPassword { get; set; } = null!;

    [CheckboxRequired(ErrorMessage = "You must accept the terms and conditions to proceed")]
    [Display(Name = "I agree to the Terms & Conditions.", Prompt = "Terms and Conditions")]
    public bool TermsAndConditions { get; set; }
}
