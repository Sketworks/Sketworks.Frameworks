namespace Sketworks.Core.Intefaces.Pattern.CQRS;

public interface IQuery<T> where T : class
{
    Task<T> GetAsync(string id, CancellationToken cancellationToken);
    Task<T> GetAllAsync(CancellationToken cancellationToken);
}