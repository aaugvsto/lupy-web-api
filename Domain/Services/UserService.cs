using Lupy.Domain.Entities;
using Lupy.Domain.Interfaces.IRepositories.Base;
using Lupy.Domain.Interfaces.IServices;
using Lupy.Domain.Records.DTOs;
using Lupy.Domain.Services.Base;

namespace Lupy.Domain.Services
{
    public class UserService : Service<User>, IUserService
    {
        public UserService(IRepository<User> repository) : base(repository) { }

        public async Task<User?> Authenticate(UserLoginDTO item)
        {
            var users = await base.Repository.Query(x => x.Email == item.Email && x.Password == item.Password, includes: x => x.Clinic);
            return users.SingleOrDefault();
        }
    }
}
