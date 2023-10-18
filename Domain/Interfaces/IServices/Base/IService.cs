using Lupy.Domain.Entities.Base;
using Lupy.Domain.Records.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lupy.Domain.Interfaces.IServices.Base
{
    public interface IService<T> where T : Entity
    {
        public Task<IEnumerable<T>> GetAsync();
        public Task<T?> FindAsync(int id);
        public Task<bool> DeleteAsync(int id);
        public Task<T> CreateAsync(T entity);
        public Task<bool> UpdateAsync(T entity);
    }
}
