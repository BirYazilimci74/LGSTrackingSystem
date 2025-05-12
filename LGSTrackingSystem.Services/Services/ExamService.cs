using LGSTrackingSystem.Domain.Interfaces;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Repositories;
using LGSTrackingSystem.Repositories.Repositories;

namespace LGSTrackingSystem.Services.Services
{
    public class ExamService
    {
        private readonly IRepository<Exam> _examRepository;

        public ExamService()
        {
            _examRepository = new ExamRepository(new LGSTrackingDBContext());
        }

        public void AddExamToStudent(Student student,Exam newExam)
        {
            if (_examRepository is ExamRepository repository)
                repository.AddExamToStudentAsync(student, newExam);
        }

        public void DeleteExam(Exam exam)
        {
            if (exam is not null)
            {
                _examRepository.Delete(exam);
                return;
            }
        }

        public async Task<Exam> GetByIdAsync(int id)
        {
            var exam = await _examRepository.GetByIdAsync(id);
            if (exam is null)
                throw new Exception("Exam not found");
            return exam;
        }
    }
}
