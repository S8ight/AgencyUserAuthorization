using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Request;

public class VerifyEmailRequest
{
    [Required]
    public string Token { get; set; }
    public string Email { get; set; }
}