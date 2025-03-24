﻿namespace Universe.Core
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        Task InsertAsync(T Entity);
        Task UpdateAsync(T Entity);
        Task DeleteAsync(T Entity);
        Task<List<T>> SelectAsync(System.Linq.Expressions.Expression<Func<T, bool>> Predicate, params System.Linq.Expressions.Expression<Func<T, object>>[] IncludeProperties);
    }
}