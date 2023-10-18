using Lupy.Domain.Entities;
using Lupy.Domain.Interfaces.IServices.Base;
using Lupy.Domain.Records.DTOs;


namespace Lupy.Domain.Interfaces.IServices
{
    public interface IUserService : IService<User>
    {
        public Task<User?> Authenticate(UserLoginDTO user);
    }
}
