using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace LGSTrackingSystem.Services.Services
{
    public abstract class Service<T> where T : class
    {
        protected readonly LGSTrackingDBContext _context;

        protected Service(LGSTrackingDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public async Task UpdateAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
