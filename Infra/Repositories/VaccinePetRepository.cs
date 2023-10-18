using Infra.DataAccess;
using Lupy.Domain.Entities;
using Lupy.Domain.Interfaces.IRepositories;
using Lupy.Infra.Repositories.Base;

namespace Lupy.Infra.Repositories
{
    public class VaccinePetRepository : Repository<VaccinePet>, IVaccinePetRepository
    {
        public VaccinePetRepository(DBContext DbContext)
            : base(DbContext) { }
    }
}
 