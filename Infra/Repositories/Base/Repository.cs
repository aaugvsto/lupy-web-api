using Infra.DataAccess;
using Lupy.Domain.Entities.Base;
using Lupy.Domain.Interfaces.IRepositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Data;

namespace Lupy.Infra.Repositories.Base
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly DBContext _dbContext;

        protected DbSet<T> DbSet { get { return this._dbContext.Set<T>(); } }

        public Repository(DBContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<T>> GetAsync() => await DbSet.ToListAsync();

        public async Task<T?> FindAsync(int id) => await this.DbSet.FindAsync(id);

        public async Task<T> CreateAsync(T entity)
        {
            this.DbSet.Add(entity);
            await this.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            entity.ModificationDate = DateTime.Now;

            var entry = this.DbSet.Entry(entity);
            entry.State = EntityState.Modified;

            return await this.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await this.FindAsync(id);

            if (entity is null)
                return false;

            this.DbSet.Remove(entity);
            return await this.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<T>> Query(Expression<Func<T, bool>> where)
        {
            return await DbSet.Where(where).ToListAsync();
        }

        public async Task<IEnumerable<T>> Query(Expression<Func<T, bool>> where, string[] includes)
        {
            var query = this.DbSet.AsQueryable();

            foreach (var item in includes)
                query = query.Include(item);

            return await query.Where(where).ToListAsync();
        }

        public async Task<IEnumerable<T>> Query(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includes)
        {
            var query = this.DbSet.AsQueryable();

            foreach (var item in includes)
                query = query.Include(item);

            return await query.Where(where).ToListAsync();
        }

        public async Task<int> SaveChangesAsync() => await this._dbContext.SaveChangesAsync();
    }
}
