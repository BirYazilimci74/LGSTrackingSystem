using LGSTrackingSystem.Domain.Interfaces;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Repositories;
using LGSTrackingSystem.Repositories.Repositories;

namespace LGSTrackingSystem.Services.Services
{
    public class StudentService
    {
        private readonly LGSTrackingDBContext _dbContext;
        private readonly IRepository<Student> _studentRepository;

        public StudentService()
        {
            _dbContext = new LGSTrackingDBContext();
            _studentRepository = new StudentRepository(_dbContext);
        }

        public async Task<Student?> GetStudentByUserIdAsync(int userId)
        {
            if (_studentRepository is StudentRepository repository)
                return await repository.GetStudentByUserIdAsync(userId);
            return null;
        }
    }
}
