using Infra.DataAccess;
using Lupy.Domain.Entities;
using Lupy.Domain.Interfaces.IRepositories;
using Lupy.Infra.Repositories.Base;

namespace Lupy.Infra.Repositories
{
    public class ClinicRepository : Repository<Clinic>, IClinicRepository
    {
        public ClinicRepository(DBContext DbContext)
            : base(DbContext) { }
    }
}
 