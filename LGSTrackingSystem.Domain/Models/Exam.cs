using System.ComponentModel.DataAnnotations;

namespace LGSTrackingSystem.Domain.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        public DateTime ExamDate { get; set; }
        public string EnteredBy { get; set; }

        public int MathCorrect { get; set; } = 0;
        public int MathIncorrect { get; set; } = 0;
        public double MathNet { get; set; } = 0;

        public int ScienceCorrect { get; set; } = 0;
        public int ScienceIncorrect { get; set; } = 0;
        public double ScienceNet { get; set; } = 0;

        public int TurkishCorrect { get; set; } = 0;
        public int TurkishIncorrect { get; set; } = 0;
        public double TurkishNet { get; set; } = 0;

        public int HistoryCorrect { get; set; } = 0;
        public int HistoryIncorrect { get; set; } = 0;
        public double HistoryNet { get; set; } = 0;

        public int ReligionCorrect { get; set; } = 0;
        public int ReligionIncorrect { get; set; } = 0;
        public double ReligionNet { get; set; } = 0;

        public int EnglishCorrect { get; set; } = 0;
        public int EnglishIncorrect { get; set; } = 0;
        public double EnglishNet { get; set; } = 0;

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
