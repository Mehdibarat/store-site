using Domain.Entities.Base;

namespace Application.Contracts;

public interface IGenericRepository<T> where T :BaseEntity
{
    Task<T> GetByAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(int id);

}

