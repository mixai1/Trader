﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Trader.Domain.IServices
{
    public interface IDataService <T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Create(T entity);
        Task<T> Update(int id, T entity);
        Task<bool> Delete(int id);
    }
}
