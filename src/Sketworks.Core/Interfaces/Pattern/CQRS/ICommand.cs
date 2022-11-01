namespace Sketworks.Core.Intefaces.Pattern.CQRS;

public interface ICommand<T> where T : class
{
    Task? CreateAsync(T entity, CancellationToken cancellationToken);
    Task? DeleteAsync(T entity, CancellationToken cancellationToken);
    Task? DeleteByIdAsync(string id, CancellationToken cancellationToken);
    Task<T> UpdateAsync(T entity, CancellationToken cancellationToken);
    Task<T> UpdateByIdAsync(string id, T entity, CancellationToken cancellationToken);

}