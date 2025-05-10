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

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _studentRepository.GetAllAsync();
        }

        public async Task<Student?> GetStudentByIdAsync(int id)
        {
            return await _studentRepository.GetByIdAsync(id);
        }

        public void AddStudent(Student student)
        {
            _studentRepository.Add(student);
        }

        public async Task UpdateStudentAsync(int id, Student student)
        {
            await _studentRepository.UpdateAsync(id, student);
        }

        public async Task<List<Exam>> GetExamsFromStudent(int studentId)
        {
            var student = await _studentRepository.GetByIdAsync(studentId);
            if (student != null)
            {
                return student.Exams;
            }
            return new List<Exam>()
            {
                new Exam()
                {
                    Id = 0,
                    ExamDate = DateTime.Now,
                    EnteredBy = "No exams found",
                }
            };       
        }
    }
}
