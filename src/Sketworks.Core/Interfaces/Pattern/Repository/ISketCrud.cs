using Sketworks.Domain.Entities.Core.Model.Base.User;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sketworks.Application.Interfaces.Pattern.Repository
{
    internal interface ISketCrud<T> where T : ISketPersistedModel
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);
        Task<T> FindOneAsync(Expression<Func<T, bool>> expression);

        Task BeforeCreatedAsync(T entity);
        Task<T> CreateAsync(T entity);
        Task AfterCreatedAsync(T entity);

        Task BeforeUpdatedAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task AfterUpdatedAsync(T entity);

        Task BeforeDeletedAsync(T entity);
        Task DeleteAsync(T entity);
        Task AfterDeletedAsync(T entity);

        Task<bool> ExistAsync(T entity);
        Task<long> CountAsync();

    }
}