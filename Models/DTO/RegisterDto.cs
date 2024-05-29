using System.ComponentModel.DataAnnotations;

namespace Walks.Models.DTO;

public class RegisterDto
{
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Username { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    public string[] Roles { get; set; }
}