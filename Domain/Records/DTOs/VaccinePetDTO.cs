#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Lupy.Domain.Records.DTOs
{
    public record VaccinePetDTO
    {
        [Required] public int IdPet { get; set; }
        [Required] public int IdVaccine { get; set; }
    }
}
