using System.ComponentModel.DataAnnotations;

namespace DotnetAuth.Api.Models;


public class RegisterModel
{
    [Required(ErrorMessage = "The username field is required")]
    public string UserName { get; set; } = string.Empty;
    [EmailAddress(ErrorMessage = "Use the proper email format")]
    [Required(ErrorMessage = "Email field is required")]
    public string Email { get; set; } = string.Empty;
    [Required(ErrorMessage = "Password field is required")]
    public string Password { get; set; } = string.Empty;
}