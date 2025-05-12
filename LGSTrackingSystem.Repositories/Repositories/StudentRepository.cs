using LGSTrackingSystem.Domain.Interfaces;
using LGSTrackingSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LGSTrackingSystem.Repositories.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly LGSTrackingDBContext _context;

        public StudentRepository(LGSTrackingDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Student entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _context.Students
                .Include(s => s.User)
                .Include(s => s.Exams)
                .ToListAsync();
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _context.Students
                .Include(s => s.User)
                .Include(s => s.Exams)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task UpdateAsync(int id, Student entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            var existingEntity = await GetByIdAsync(id);
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

            await _context.SaveChangesAsync();
        }

        public async Task<Student?> GetStudentByUserIdAsync(int userId)
        {
            return await _context.Students
                .Include(s => s.User)
                .Include(s => s.Exams)
                .FirstOrDefaultAsync(s => s.UserId == userId);
        }

        public void Delete(Student entity)
        {
            _context.Students.Remove(entity);
            _context.SaveChanges();
        }
    }
}
