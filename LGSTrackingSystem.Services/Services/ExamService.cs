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

        public (bool,string) CheckAndCalculateNet(decimal correct, decimal incorrect, int maxNet)
        {
            string strNet;
            if (correct + incorrect > maxNet)
            {
                strNet = $"should be less than {maxNet}";
                return (false,strNet);
            }
            var net = ((double)correct - ((double)incorrect / 3 + ((double)incorrect % 3) * 0.33));
            strNet = net.ToString("0.00");
            return (true,strNet);
        }
    }
}
