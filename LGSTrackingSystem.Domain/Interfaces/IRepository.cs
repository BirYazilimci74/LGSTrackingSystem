namespace LGSTrackingSystem.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        Task UpdateAsync(int id, T entity);
        Task<T?> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
        void Delete(T entity);
    }
}
