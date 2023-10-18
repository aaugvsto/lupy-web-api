#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Lupy.Domain.Records.DTOs
{
    public record PetDTO
    {
        public int? Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Age { get; set; }
        [Required] public string UserId { get; set; }
    }
}
