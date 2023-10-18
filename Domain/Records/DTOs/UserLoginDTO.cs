#nullable disable

using Lupy.Domain.Records.DTOs;
using System.ComponentModel.DataAnnotations;

namespace Lupy.Domain.Records.DTOs
{
    public record UserLoginDTO
    {
        [Required] public string Email { get; set; }

        [Required] public string Password { get; set; }
    }
}
