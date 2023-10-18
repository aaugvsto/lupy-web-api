#nullable disable

using Lupy.Domain.Entities.Base;

namespace Lupy.Domain.Entities
{
    public class Role : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
