#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Lupy.Domain.Records.DTOs
{
    public record ClinicDTO
    {
        public int? Id { get; set; }
        [Required] public string Name { get; set; }
    }
}
