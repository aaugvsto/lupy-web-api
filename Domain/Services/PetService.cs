using Lupy.Domain.Entities;
using Lupy.Domain.Interfaces.IRepositories.Base;
using Lupy.Domain.Interfaces.IServices;
using Lupy.Domain.Records.DTOs;
using Lupy.Domain.Services.Base;

namespace Lupy.Domain.Services
{
    public class PetService : Service<Pet>, IPetService
    {
        public PetService(IRepository<Pet> repository) : base(repository) { }
    }
}
