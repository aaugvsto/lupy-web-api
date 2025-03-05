using Lupy.Domain.Entities.Base;

namespace Lupy.Domain.Entities
{
    public class Vaccine : Entity
    {
        public Vaccine()
        {
            VaccinePet = new List<VaccinePet>();
        }

        public string? Name { get; set; }
        public string? Batch { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int IdClinic { get; set; }

        public virtual Clinic? Clinic { get; set; }
        public virtual ICollection<VaccinePet> VaccinePet { get; set; }
    }
}