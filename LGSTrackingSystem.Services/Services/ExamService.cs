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

        public async Task AddExamToStudentAsync(Student student,Exam newExam)
        {
            if (_examRepository is ExamRepository repository)
                await repository.AddExamToStudentAsync(student, newExam);
        }
    }
}
