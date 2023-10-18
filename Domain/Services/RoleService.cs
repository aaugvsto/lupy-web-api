using Lupy.Domain.Entities;
using Lupy.Domain.Interfaces.IRepositories.Base;
using Lupy.Domain.Interfaces.IServices;
using Lupy.Domain.Records.DTOs;
using Lupy.Domain.Services.Base;

namespace Lupy.Domain.Services
{
    public class RoleService : Service<Role>, IRoleService
    {
        public RoleService(IRepository<Role> repository) : base(repository) { }
    }
}
