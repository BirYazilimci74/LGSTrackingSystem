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
    }
}
