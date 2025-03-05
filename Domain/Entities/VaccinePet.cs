using Lupy.Domain.Entities.Base;

namespace Lupy.Domain.Entities
{
    public class VaccinePet : Entity
    {
        public int IdVaccine { get; set; }
        public int IdClinic { get; set; }
        public int IdPet { get; set; }

        public virtual Clinic? Clinic { get; set; }
        public virtual Pet? Pet { get; set; }
        public virtual Vaccine? Vaccine { get; set; }
    }
}