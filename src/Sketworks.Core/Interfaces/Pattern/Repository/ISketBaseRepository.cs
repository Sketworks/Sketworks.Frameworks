using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Sketworks.Domain.Entities.Core.Model.Base.User;

namespace Sketworks.Application.Interfaces.Pattern.Repository;

public abstract class ISketBaseRepository<T> : ISketCrud<T> where T : ISketPersistedModel
{
    private readonly ILogger<ISketBaseRepository<T>> _logger;

    #region Implementation of ISketCrud<T>

    public ISketBaseRepository(ILogger<ISketBaseRepository<T>> logger)
    {
        _logger = logger;
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<T> FindOneAsync(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public virtual async Task BeforeCreatedAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<T> CreateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task AfterCreatedAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task BeforeUpdatedAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task AfterUpdatedAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task BeforeDeletedAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task AfterDeletedAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<bool> ExistAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<long> CountAsync()
    {
        throw new NotImplementedException();
    }

    #endregion
}