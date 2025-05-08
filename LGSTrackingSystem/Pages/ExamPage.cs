using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Pages
{
    public partial class ExamPage : Form
    {
        private readonly ExamService _examService;
        private readonly Student? _student;
        private readonly Exam? _exam;
        public ExamPage(Student student)
        {
            _student = student;
            _examService = new ExamService();
            InitializeComponent();
        }

        public ExamPage()
        {
            _examService = new ExamService();
            InitializeComponent();
        }

        private void AddExam()
        {
            var newExam = new Exam
            {
                ExamDate = DateTime.Now,
                EnteredBy = _student is null ? "Admin" : "Student",
                MathCorrect = Convert.ToInt32(numMathCorrect.Value),
                MathIncorrect = Convert.ToInt32(numMathIncorrect.Value),
                MathNet = Convert.ToDouble(numMathCorrect.Value) - (Convert.ToDouble(numMathIncorrect.Value) * 0.33),
                
                ScienceCorrect = Convert.ToInt32(numScienceCorrect.Value),
                ScienceIncorrect = Convert.ToInt32(numScienceIncorrect.Value),
                ScienceNet = Convert.ToDouble(numScienceCorrect.Value) - (Convert.ToDouble(numScienceIncorrect.Value) * 0.33),
                
                TurkishCorrect = Convert.ToInt32(numTurkishCorrect.Value),
                TurkishIncorrect = Convert.ToInt32(numTurkishIncorrect.Value),
                TurkishNet = Convert.ToDouble(numTurkishCorrect.Value) - (Convert.ToDouble(numTurkishIncorrect.Value) * 0.33),
                
                HistoryCorrect = Convert.ToInt32(numHistoryCorrect.Value),
                HistoryIncorrect = Convert.ToInt32(numHistoryIncorrect.Value),
                HistoryNet = Convert.ToDouble(numHistoryCorrect.Value) - (Convert.ToDouble(numHistoryIncorrect.Value) * 0.33),
                
                ReligionCorrect = Convert.ToInt32(numReligionCorrect.Value),
                ReligionIncorrect = Convert.ToInt32(numReligionIncorrect.Value),
                ReligionNet = Convert.ToDouble(numReligionCorrect.Value) - (Convert.ToDouble(numReligionIncorrect.Value) * 0.33),
                
                EnglishCorrect = Convert.ToInt32(numEnglishCorrect.Value),
                EnglishIncorrect = Convert.ToInt32(numEnglishIncorrect.Value),
                EnglishNet = Convert.ToDouble(numEnglishCorrect.Value) - (Convert.ToDouble(numEnglishIncorrect.Value) * 0.33),
                
                StudentId = _student.Id,
                Student = _student
            };
            _examService.AddExamToStudent(_student, newExam);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AddExam();
            MessageBox.Show("Exam added successfully.");
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
