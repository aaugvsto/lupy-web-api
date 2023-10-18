#nullable disable

using Lupy.Domain.Entities.Base;

namespace Lupy.Domain.Entities
{
    public class Pet : Entity
    {
        public Pet()
        {
            VaccinePet = new List<VaccinePet>();
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int IdUser { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<VaccinePet> VaccinePet { get; set; }
    }
}