using System.ComponentModel.DataAnnotations;

namespace AspNetCore_MVC.ViewModels;

public class AccountDetailsViewModel
{
    public AccountBasicInfo? Basic { get; set; }
    public AccountAddressInfo? Address { get; set; }
}

public class AccountBasicInfo 
{
    [Required]
    [Display(Name = "First name", Prompt = "Enter your first name")]
    public string FirstName { get; set; } = null!;

    [Required]
    [Display(Name = "Last name", Prompt = "Enter your last name")]
    public string LastName { get; set; } = null!;

    [Required]
    [Display(Name = "E-mail address", Prompt = "Enter your e-mail address")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Display(Name = "Phone number (Optional)", Prompt = "Enter your phone number")]
    public string? PhoneNumber { get; set; }

    [Display(Name = "Bio (Optional)", Prompt = "Add a short bio...")]
    public string? Bio { get; set; }

}

public class AccountAddressInfo
{
    [Required]
    [Display(Name = "Address line 1", Prompt = "Enter first address line")]
    public string AddressLine_1 { get; set; } = null!;

    [Display(Name = "Address line 2", Prompt = "Enter second address line")]
    public string? AddressLine_2 { get; set; }

    [Required]
    [Display(Name = "Postal code", Prompt = "Enter your postal code")]
    public string PostalCode { get; set; } = null!;

    [Required]
    [Display(Name = "City", Prompt = "Enter your city")]
    public string City { get; set; } = null!;
}
