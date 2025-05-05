using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Repositories.Repositories
{
    internal class UserRepository : IRepository<User>
    {
        private readonly Service<User> _service;
        public UserRepository(Service<User> service)
        {
            _service = service;
        }
        public void Add(User entity)
        {
            _service.Add(entity);
        }
        public async Task<List<User>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }
        public Task<User> GetByIdAsync(int id)
        {
            return _service.GetByIdAsync(id);
        }
        public async Task UpdateAsync(int id, User entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            var existingUser = await _service.GetByIdAsync(id);
            if (existingUser == null)
            {
                throw new ArgumentException($"User with ID {id} not found.");
            }
            existingUser.Username = entity.Username;
            existingUser.Password = entity.Password;
            existingUser.Role = entity.Role;

            await _service.UpdateAsync();
        }
    }
}
