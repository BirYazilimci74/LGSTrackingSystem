using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Repositories.Repositories
{
    public class ExamRepository : IRepository<Exam>
    {
        private readonly Service<Exam> _service;
        public ExamRepository(Service<Exam> service)
        {
            _service = service;
        }

        public void Add(Exam entity)
        {
            _service.Add(entity);
        }

        public async Task<List<Exam>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        public async Task<Exam> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        public async Task UpdateAsync(int id, Exam entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            var existingEntity = await _service.GetByIdAsync(id);
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

            await _service.UpdateAsync();
        }
    }
}
