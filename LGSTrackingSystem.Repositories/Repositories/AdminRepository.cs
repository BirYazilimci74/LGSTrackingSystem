using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Repositories.Repositories
{
    public class AdminRepository : IRepository<Admin>
    {
        private readonly Service<Admin> _sevice;
        public AdminRepository(Service<Admin> service)
        {
            _sevice = service;
        }

        public void Add(Admin entity)
        {
            _sevice.Add(entity);
        }

        public async Task<List<Admin>> GetAllAsync()
        {
            return await _sevice.GetAllAsync();
        }

        public async Task<Admin> GetByIdAsync(int id)
        {
            return await _sevice.GetByIdAsync(id);
        }

        public async Task UpdateAsync(int id, Admin entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            var existingEntity = await _sevice.GetByIdAsync(id);
            if (existingEntity == null) throw new ArgumentException($"Admin '{entity.FirstName}' not found.");

            existingEntity.FirstName = entity.FirstName;
            existingEntity.LastName = entity.LastName;
            existingEntity.Email = entity.Email;
            existingEntity.PhoneNumber = entity.PhoneNumber;
            existingEntity.UserId = entity.UserId;
            existingEntity.User = entity.User;

            await _sevice.UpdateAsync();
        }

        public async Task<Admin> GetAdminByUserIdAsync(int userId)
        {
            if (_sevice is AdminService service)
                return await service.GetAdminByUserId(userId);
            throw new InvalidOperationException("Service is not of type AdminService.");
        }
    }
}
