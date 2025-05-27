using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGSTrackingSystem.Core.DTOs
{
    public record ExamResultDTO(
        int Id,
        string ExamName,
        DateTime ExamDate,
        string EnteredBy,
        double MathNet,
        double ScienceNet,
        double TurkishNet,
        double HistoryNet,
        double ReligionNet,
        double EnglishNet,
        double Score
    );

    public record ExamDisplayDTO(
        int Id,
        DateTime ExamDate,
        string ExamName,
        double TotalNet,
        double Score
    );
}
