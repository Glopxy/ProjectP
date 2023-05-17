using Microsoft.EntityFrameworkCore;
using PinternAPI.Core.Application.Interfaces;
using PinternAPI.Persistance.Context;
using System.Linq.Expressions;

namespace PinternAPI.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly PinternContext pinternContext;

        public Repository(PinternContext pinternContext)
        {
            this.pinternContext = pinternContext;
        }

        public async Task CreateAsync(T entity)
        {
            await this.pinternContext.Set<T>().AddAsync(entity);
            await this.pinternContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await this.pinternContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await this.pinternContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);

        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await this.pinternContext.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            this.pinternContext.Set<T>().Remove(entity);
            await this.pinternContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            this.pinternContext.Set<T>().Update(entity);
            await this.pinternContext.SaveChangesAsync();
        }
    }
}
