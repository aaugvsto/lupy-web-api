using Infra.DataAccess;
using Lupy.Domain.Entities;
using Lupy.Domain.Interfaces.IRepositories;
using Lupy.Infra.Repositories.Base;

namespace Lupy.Infra.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DBContext DbContext)
            : base(DbContext) { }
    }
}
 