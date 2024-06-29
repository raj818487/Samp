using Ardalis.Result;
using SAMP.Application.Services;
using SAMP.Domain.Common;
using SAMP.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace SAMP.Persistence.Services;
public class ServiceBase<T>(DbContext context) : IServiceBase<T> where T : class
{
    protected readonly DbContext _context = context ?? throw new ArgumentNullException(nameof(context));

    public async Task<Result<T>> Add(T entity, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(entity);
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync(cancellationToken);
        return entity;
    }
    public async Task<Result<T>> Update(T entity, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(entity);
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync(cancellationToken);
        return entity;
    }
    public async Task Delete(T entity, CancellationToken cancellationToken)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync(cancellationToken);
    }
    public async Task<Result<T>> UpdateEntity(int id, T entity, CancellationToken cancellationToken)
    {
        // Fetch the existing entity from the database
        var existingEntity = await _context.Set<T>().FindAsync(id) ?? throw new KeyNotFoundException("Entity not found");

        // Get the properties of the entity
        var properties = typeof(T).GetProperties();

        // Update the properties that have been changed
        foreach (var property in properties)
        {
            var currentValue = property.GetValue(entity);
            var originalValue = property.GetValue(existingEntity);

            if (currentValue != null && !currentValue.Equals(originalValue))
            {
                property.SetValue(existingEntity, currentValue);
                _context.Entry(existingEntity).Property(property.Name).IsModified = true;
            }
        }

        // Save changes
        await _context.SaveChangesAsync(cancellationToken);
        return entity;
    }
    public async Task<Result<T>> UpdateSpecificFields(int id, T entity, 
        CancellationToken cancellationToken,
        params string[] propertiesToUpdate)
    {
        // Fetch the existing entity from the database
        var existingEntity = await _context.Set<T>().FindAsync(id) ?? throw new KeyNotFoundException("Entity not found");

        // Update the specified properties
        var entityEntry = _context.Entry(existingEntity);
        foreach (var propertyName in propertiesToUpdate)
        {
            var actualPropertyName = entityEntry.Metadata.GetProperties()
            .FirstOrDefault(p => p.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase))?.Name;

            if (actualPropertyName == null)
            {
                throw new ArgumentException($"Property '{propertyName}' not found on entity '{entityEntry.Metadata.Name}'");
            }
            var property = entityEntry.Property(actualPropertyName);
            if (actualPropertyName != null)
            {
                property.CurrentValue = _context.Entry(entity).Property(propertyName).CurrentValue;
                property.IsModified = true;
            }
        }

        // Save changes
        await _context.SaveChangesAsync(cancellationToken);
        return entity;
    }
    public virtual async Task<Result<IEnumerable<T>>> GetAll(CancellationToken cancellationToken)
    {
        return await _context.Set<T>().ToListAsync(cancellationToken);
    }
    public async Task<T> GetById(int id, CancellationToken cancellationToken)
    {
        return await _context.Set<T>().FindAsync([id], cancellationToken);
    }
    public async Task<Result<IEnumerable<T>>> GetFilterList(QueryParameters<T> parameters, 
        CancellationToken cancellationToken)
    {
        var results = _context.Set<T>().ApplyQueryParameters(parameters);
        return await results.ToListAsync(cancellationToken);
    }
}


