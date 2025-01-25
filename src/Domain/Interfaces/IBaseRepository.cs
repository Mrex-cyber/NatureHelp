﻿namespace Domain.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> UpdateRangeAsync(IEnumerable<T> list);
        Task SaveChangesAsync();
    }
}
