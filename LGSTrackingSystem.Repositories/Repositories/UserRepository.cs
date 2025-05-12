using LGSTrackingSystem.Domain.Interfaces;
using LGSTrackingSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LGSTrackingSystem.Repositories.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly LGSTrackingDBContext _context;

        public UserRepository(LGSTrackingDBContext context)
        {
            _context = context;
        }

        public void Add(User entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task UpdateAsync(int id, User entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            var existingUser = await GetByIdAsync(id);
            if (existingUser == null)
            {
                throw new ArgumentException($"User with ID {id} not found.");
            }
            existingUser.Username = entity.Username;
            existingUser.Password = entity.Password;
            existingUser.Role = entity.Role;

            await _context.SaveChangesAsync();
        }

        public async Task<User?> GetUserByUsernameAndPasswordAsync(string username, string password)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
        }

        public void Delete(User entity)
        {
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }
    }
}
