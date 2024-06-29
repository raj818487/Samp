using Ardalis.Result;
using SAMP.Domain.Common;

namespace SAMP.Application.Services;
public interface IServiceBase<T> where T : class
{
    Task<T> GetById(int id, CancellationToken cancellationToken);
    Task<Result<T>> Add(T entity, CancellationToken cancellationToken);
    Task<Result<T>> Update(T entity, CancellationToken cancellationToken);
    Task Delete(T entity, CancellationToken cancellationToken);
    Task<Result<T>> UpdateEntity(int id, T entity, CancellationToken cancellationToken);
    Task<Result<T>> UpdateSpecificFields(int id, T entity, CancellationToken cancellationToken, params string[] propertiesToUpdate);
    Task<Result<IEnumerable<T>>> GetAll(CancellationToken cancellationToken);
    Task<Result<IEnumerable<T>>> GetFilterList(QueryParameters<T> parameters, CancellationToken cancellationToken);
}

