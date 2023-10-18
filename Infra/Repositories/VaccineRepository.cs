using Infra.DataAccess;
using Lupy.Domain.Entities;
using Lupy.Domain.Interfaces.IRepositories;
using Lupy.Infra.Repositories.Base;

namespace Lupy.Infra.Repositories
{
    public class VaccineRepository : Repository<Vaccine>, IVaccineRepository
    {
        public VaccineRepository(DBContext DbContext)
            : base(DbContext) { }
    }
}
 