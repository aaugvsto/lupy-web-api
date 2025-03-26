#nullable disable

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lupy.Domain.Records.DTOs
{
    public record UserDTO
    {
        public int? Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Cellphone { get; set; }

        [Required]
        [JsonIgnore]
        public string Password { get; set; }

        [Required] public int IdRole { get; set; }
        [Required] public int IdClinic { get; set; }
    }
}
