#nullable disable

using Lupy.Domain.Entities.Base;

namespace Lupy.Domain.Entities
{
    public class User : Entity
    {
        public User()
        {
            Pet = new List<Pet>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string Password { get; set; }
        public int IdRole { get; set; }
        public int IdClinic { get; set; }

        public virtual ICollection<Pet> Pet { get; set; }
        public virtual Role Role { get; set; }
        public virtual Clinic Clinic { get; set; }
    }
}