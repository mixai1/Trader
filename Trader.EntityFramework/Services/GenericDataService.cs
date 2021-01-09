using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Trader.Domain.IServices;
using Trader.Domain.Models;

namespace Trader.EntityFramework.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObjectId
    {
        private readonly DbSet<T> _dbSet;
        private readonly TraderDbContext _traderDbContext;

        public GenericDataService(TraderDbContext traderDbContext)
        {
            _traderDbContext = traderDbContext;
            _dbSet = _traderDbContext.Set<T>();
        }

        public async Task<T> Create(T entity)
        {
            var result = await _dbSet.AddAsync(entity);
            await _traderDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
            if (result is null)
            {
                return false;
            }
            _dbSet.Remove(result);
            await _traderDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<T> Get(int id)
        {
            var result = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var result = await _dbSet.ToListAsync();
            return result;
        }

        public async Task<T> Update(int id, T entity)
        {
            entity.Id = id;
            _dbSet.Update(entity);
            await _traderDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
