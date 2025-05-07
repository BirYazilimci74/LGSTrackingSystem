using LGSTrackingSystem.Core.DTOs;
using LGSTrackingSystem.Domain.Models;

namespace LGSTrackingSystem.Services.Mappers
{
    public static class ExamMapper
    {
        public static ExamResultDTO ToExamResultDTO(this Exam exam)
        {
            return new ExamResultDTO(
                exam.ExamDate,
                exam.EnteredBy,
                exam.MathNet,
                exam.ScienceNet,
                exam.TurkishNet,
                exam.HistoryNet,
                exam.ReligionNet,
                exam.EnglishNet
            );
        }
    }
}
