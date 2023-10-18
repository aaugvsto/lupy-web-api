#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Lupy.Domain.Records.DTOs
{
    public record VaccineDTO
    {
        public int? Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Batch { get; set; }
        [Required] public DateTime ExpirationDate { get; set; }
        [Required] public int IdClinic { get; set; }
    }
}
