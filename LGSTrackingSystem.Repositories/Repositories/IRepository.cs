using System.Collections.Generic;
using System.Threading.Tasks;

namespace LGSTrackingSystem.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        Task UpdateAsync(int id, T entity);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();
    }
}
