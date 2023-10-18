#nullable disable

using Lupy.Domain.Entities.Base;

namespace Lupy.Domain.Entities
{
    public class Clinic : Entity
    {
        public Clinic()
        {
            VaccinePet = new List<VaccinePet>();
        }

        public string Name { get; set; }

        public virtual ICollection<Vaccine> Vaccines { get; set; }
        public virtual ICollection<VaccinePet> VaccinePet { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}