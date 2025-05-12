using LGSTrackingSystem.Domain.Interfaces;
using LGSTrackingSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LGSTrackingSystem.Repositories.Repositories
{
    public class AdminRepository : IRepository<Admin>
    {
        private readonly LGSTrackingDBContext _context;

        public AdminRepository(LGSTrackingDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Admin entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public async Task<List<Admin>> GetAllAsync()
        {
            return await _context.Admins
                .Include(a => a.User)
                .ToListAsync();
        }

        public async Task<Admin?> GetByIdAsync(int id)
        {
            return await _context.Admins
                .Include(a => a.User)
                .FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task UpdateAsync(int id, Admin entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            var existingEntity = await GetByIdAsync(id);
            if (existingEntity == null) throw new ArgumentException($"Admin '{entity.FirstName}' not found.");

            existingEntity.FirstName = entity.FirstName;
            existingEntity.LastName = entity.LastName;
            existingEntity.Email = entity.Email;
            existingEntity.PhoneNumber = entity.PhoneNumber;
            existingEntity.UserId = entity.UserId;
            existingEntity.User = entity.User;

            await _context.SaveChangesAsync();
        }

        public async Task<Admin?> GetAdminByUserIdAsync(int userId)
        {
            return await _context.Admins
                .Include(a => a.User)
                .FirstOrDefaultAsync(a => a.UserId == userId);
        }

        public void Delete(Admin entity)
        {
            _context.Admins.Remove(entity);
            _context.SaveChanges();
        }
    }
}
