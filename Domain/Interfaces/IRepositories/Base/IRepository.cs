using Lupy.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lupy.Domain.Interfaces.IRepositories.Base
{
    public interface IRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAsync();
        public Task<T?> FindAsync(int id); 
        public Task<bool> DeleteAsync(int id);
        public Task<T> CreateAsync(T entity);
        public Task<bool> UpdateAsync(T entity);
        public Task<IEnumerable<T>> Query(Expression<Func<T, bool>> where);
        public Task<IEnumerable<T>> Query(Expression<Func<T, bool>> where, string[] includes);
        public Task<IEnumerable<T>> Query(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes);
    }
}
