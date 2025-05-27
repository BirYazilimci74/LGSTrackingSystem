using LGSTrackingSystem.Core.DTOs;
using LGSTrackingSystem.Domain.Models;

namespace LGSTrackingSystem.Services.Mappers
{
    public static class ExamMapper
    {
        public static ExamResultDTO ToExamResultDTO(this Exam exam)
        {
            return new ExamResultDTO(
                exam.Id,
                exam.ExamName,
                exam.ExamDate,
                exam.EnteredBy,
                exam.MathNet,
                exam.ScienceNet,
                exam.TurkishNet,
                exam.HistoryNet,
                exam.ReligionNet,
                exam.EnglishNet,
                exam.Score
            );
        }

        public static ExamDisplayDTO ToExamDisplayDTO(this Exam exam)
        {
            return new ExamDisplayDTO(
                exam.Id,
                exam.ExamDate,
                exam.ExamName,
                exam.TotalNet,
                exam.Score
            );
        }
    }
}
