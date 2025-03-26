using Lupy.Domain.Entities;
using Lupy.Domain.Entities.Base;
using Lupy.Domain.Interfaces.IRepositories.Base;
using Lupy.Domain.Interfaces.IServices.Base;

namespace Lupy.Domain.Services.Base
{
    public abstract class Service<T> : IService<T> where T : Entity
    {
        private readonly IRepository<T> _repository;

        protected IRepository<T> Repository { get { return _repository; } }

        public Service(IRepository<T> repository) => this._repository = repository;

        public virtual async Task<T> CreateAsync(T entity) => await this._repository.CreateAsync(entity);

        public virtual async Task<bool> DeleteAsync(int id) => await this._repository.DeleteAsync(id);

        public virtual async Task<T?> FindAsync(int id) => await this._repository.FindAsync(id);

        public virtual async Task<IEnumerable<T>> GetAsync() => await this._repository.GetAsync();

        public virtual async Task<bool> UpdateAsync(T entity) => await this._repository.UpdateAsync(entity);
    }
}
