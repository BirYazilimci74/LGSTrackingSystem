using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGSTrackingSystem.Core.DTOs
{
    public record ExamResultDTO(
        DateTime ExamDate,
        string EnteredBy,
        double MathNet,
        double ScienceNet,
        double TurkishNet,
        double HistoryNet,
        double ReligionNet,
        double EnglishNet
    );
}
