using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Repositories.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly Service<Student> _service;
        public StudentRepository(Service<Student> service)
        {
            _service = service;
        }
        public void Add(Student entity)
        {
            _service.Add(entity);
        }
        public async Task<List<Student>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }
        public async Task<Student> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }
        public async Task UpdateAsync(int id, Student entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            var existingEntity = await _service.GetByIdAsync(id);
            if (existingEntity == null) throw new ArgumentException($"Student '{entity.FirstName}' not found.");
            
            existingEntity.FirstName = entity.FirstName;
            existingEntity.LastName = entity.LastName;
            existingEntity.Email = entity.Email;
            existingEntity.PhoneNumber = entity.PhoneNumber;
            existingEntity.SchoolName = entity.SchoolName;
            existingEntity.Class = entity.Class;
            existingEntity.UserId = entity.UserId;
            existingEntity.User = entity.User;
            existingEntity.Exams = entity.Exams;

            await _service.UpdateAsync();
        }

    }
}
