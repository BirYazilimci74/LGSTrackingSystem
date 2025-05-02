using System;
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
        public int MathNet { get; set; } = 0;

        public int ScienceCorrect { get; set; } = 0;
        public int ScienceIncorrect { get; set; } = 0;
        public int ScienceNet { get; set; } = 0;

        public int TurkishCorrect { get; set; } = 0;
        public int TurkishIncorrect { get; set; } = 0;
        public int TurkishNet { get; set; } = 0;

        public int HistoryCorrect { get; set; } = 0;
        public int HistoryIncorrect { get; set; } = 0;
        public int HistoryNet { get; set; } = 0;

        public int ReligionCorrect { get; set; } = 0;
        public int ReligionIncorrect { get; set; } = 0;
        public int ReligionNet { get; set; } = 0;

        public int EnglishCorrect { get; set; } = 0;
        public int EnglishIncorrect { get; set; } = 0;
        public int EnglishNet { get; set; } = 0;

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
