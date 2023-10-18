using Infra.DataAccess;
using Lupy.Domain.Entities;
using Lupy.Domain.Interfaces.IRepositories;
using Lupy.Infra.Repositories.Base;

namespace Lupy.Infra.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(DBContext DbContext)
            : base(DbContext) { }
    }
}
 