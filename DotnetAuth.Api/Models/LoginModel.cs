using System.ComponentModel.DataAnnotations;

namespace DotnetAuth.Api.Models;


public class LoginModel
{
    [Required(ErrorMessage = "UserName field is required")]
    public string UserName { get; set; } = string.Empty;
    [Required(ErrorMessage = "Password field is required")]
    public string Password { get; set; } = string.Empty;
}