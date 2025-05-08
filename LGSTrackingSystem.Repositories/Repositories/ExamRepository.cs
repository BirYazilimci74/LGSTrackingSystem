using LGSTrackingSystem.Domain.Interfaces;
using LGSTrackingSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LGSTrackingSystem.Repositories.Repositories
{
    public class ExamRepository : IRepository<Exam>
    {
        private readonly LGSTrackingDBContext _context;

        public ExamRepository(LGSTrackingDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Exam entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public async Task<List<Exam>> GetAllAsync()
        {
            return await _context.Exams
                .Include(e => e.Student)
                .ToListAsync();
        }

        public async Task<Exam?> GetByIdAsync(int id)
        {
            return await _context.Exams
                .Include(e => e.Student)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task UpdateAsync(int id, Exam entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            var existingEntity = await GetByIdAsync(id);
            if (existingEntity == null) throw new ArgumentException($"Exam of {entity.Student.FirstName} with {id} not found.");

            existingEntity.ExamDate = entity.ExamDate;
            existingEntity.EnteredBy = entity.EnteredBy;

            existingEntity.MathCorrect = entity.MathCorrect;
            existingEntity.MathIncorrect = entity.MathIncorrect;
            existingEntity.MathNet = entity.MathNet;

            existingEntity.ScienceCorrect = entity.ScienceCorrect;
            existingEntity.ScienceIncorrect = entity.ScienceIncorrect;
            existingEntity.ScienceNet = entity.ScienceNet;

            existingEntity.TurkishCorrect = entity.TurkishCorrect;
            existingEntity.TurkishIncorrect = entity.TurkishIncorrect;
            existingEntity.TurkishNet = entity.TurkishNet;

            existingEntity.HistoryCorrect = entity.HistoryCorrect;
            existingEntity.HistoryIncorrect = entity.HistoryIncorrect;
            existingEntity.HistoryNet = entity.HistoryNet;

            existingEntity.ReligionCorrect = entity.ReligionCorrect;
            existingEntity.ReligionIncorrect = entity.ReligionIncorrect;
            existingEntity.ReligionNet = entity.ReligionNet;

            existingEntity.EnglishCorrect = entity.EnglishCorrect;
            existingEntity.EnglishIncorrect = entity.EnglishIncorrect;
            existingEntity.EnglishNet = entity.EnglishNet;

            existingEntity.StudentId = entity.StudentId;
            existingEntity.Student = entity.Student;

            await _context.SaveChangesAsync();
        }

        public async void AddExamToStudentAsync(Student student, Exam newExam)
        {
            if (student == null) throw new ArgumentNullException(nameof(student));
            if (newExam == null) throw new ArgumentNullException(nameof(newExam));
            
            var existingStudent = await _context.Students
                .Include(s => s.Exams)
                .FirstOrDefaultAsync(s => s.Id == student.Id);
            
            if (existingStudent == null) throw new ArgumentException($"Student with ID {student.Id} not found.");
            
            existingStudent.Exams.Add(newExam);
            _context.SaveChanges();
        }
    }
}
