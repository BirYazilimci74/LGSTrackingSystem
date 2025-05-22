using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Pages
{
    public partial class ExamPage : Form
    {
        private readonly StudentService _studentService;
        private readonly ExamService _examService;
        private Student? _student;
        private readonly int _studentId;

        //for student
        public ExamPage(Student student)
        {
            _student = student;
            _studentService = new StudentService();
            _examService = new ExamService();
            InitializeComponent();
        }

        //for admin
        public ExamPage(int studentId)
        {
            _studentId = studentId;
            _studentService = new StudentService();
            _examService = new ExamService();
            InitializeComponent();
        }

        private async void AddExam()
        {
            lblMsg.Text = string.Empty;

            var mathCorrect = Convert.ToInt32(numMathCorrect.Value);
            var mathIncorrect = Convert.ToInt32(numMathIncorrect.Value);
            var mathResult = _examService.CheckAndCalculateNet(mathCorrect, mathIncorrect, 20);
            if (!mathResult.Item1)
            {
                lblMsg.Text += "\nTotal math question " + mathResult.Item2;
                return;
            }
            double matNet = Convert.ToDouble(mathResult.Item2);

            var scienceCorrect = Convert.ToInt32(numScienceCorrect.Value);
            var scienceIncorrect = Convert.ToInt32(numScienceIncorrect.Value);
            var scienceResult = _examService.CheckAndCalculateNet(scienceCorrect, scienceIncorrect, 20);
            if (!scienceResult.Item1)
            {
                lblMsg.Text += "\nTotal science question " + scienceResult.Item2;
                return;
            }
            double scienceNet = Convert.ToDouble(scienceResult.Item2);

            var turkishCorrect = Convert.ToInt32(numTurkishCorrect.Value);
            var turkishIncorrect = Convert.ToInt32(numTurkishIncorrect.Value);
            var turkishResult = _examService.CheckAndCalculateNet(turkishCorrect, turkishIncorrect, 20);
            if (!turkishResult.Item1)
            {
                lblMsg.Text += "\nTotal turkish question " + turkishResult.Item2;
                return;
            }
            double turkishNet = Convert.ToDouble(turkishResult.Item2);

            var historyCorrect = Convert.ToInt32(numHistoryCorrect.Value);
            var historyIncorrect = Convert.ToInt32(numHistoryIncorrect.Value);
            var historyResult = _examService.CheckAndCalculateNet(historyCorrect, historyIncorrect, 10);
            if (!historyResult.Item1)
            {
                lblMsg.Text += "\nTotal history question " + historyResult.Item2;
                return;
            }
            double historyNet = Convert.ToDouble(historyResult.Item2);

            var religionCorrect = Convert.ToInt32(numReligionCorrect.Value);
            var religionIncorrect = Convert.ToInt32(numReligionIncorrect.Value);
            var religionResult = _examService.CheckAndCalculateNet(religionCorrect, religionIncorrect, 10);
            if (!religionResult.Item1)
            {
                lblMsg.Text += "\nTotal religion question " + religionResult.Item2;
                return;
            }
            double religionNet = Convert.ToDouble(religionResult.Item2);

            var englishCorrect = Convert.ToInt32(numEnglishCorrect.Value);
            var englishIncorrect = Convert.ToInt32(numEnglishIncorrect.Value);
            var englishResult = _examService.CheckAndCalculateNet(englishCorrect, englishIncorrect, 10);
            if (!englishResult.Item1)
            {
                lblMsg.Text += "\nTotal english question " + englishResult.Item2;
                return;
            }
            double englishNet = Convert.ToDouble(englishResult.Item2);

            var newExam = new Exam
            {
                ExamDate = dtpExamDate.Value,
                ExamName = tbxExamName.Text,
                EnteredBy = _student is null ? "Admin" : "Student",

                MathCorrect = mathCorrect,
                MathIncorrect = mathIncorrect,
                MathNet = matNet,

                ScienceCorrect = scienceCorrect,
                ScienceIncorrect = scienceIncorrect,
                ScienceNet = scienceNet,

                TurkishCorrect = turkishCorrect,
                TurkishIncorrect = turkishIncorrect,
                TurkishNet = turkishNet,

                HistoryCorrect = historyCorrect,
                HistoryIncorrect = historyIncorrect,
                HistoryNet = historyNet,

                ReligionCorrect = religionCorrect,
                ReligionIncorrect = religionIncorrect,
                ReligionNet = religionNet,

                EnglishCorrect = englishCorrect,
                EnglishIncorrect = englishIncorrect,
                EnglishNet = englishNet,

                StudentId = _student?.Id ?? _studentId,
            };

            if (_student is null)
            {
                var student = await _studentService.GetStudentByIdAsync(_studentId);
                if (student is null)
                {
                    MessageBox.Show("Student not found.");
                    return;
                }
                _student = student;
            }

            _examService.AddExamToStudent(_student, newExam);
            MessageBox.Show("Exam added successfully.");
            this.DialogResult = DialogResult.OK;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AddExam();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExamPage_Load(object sender, EventArgs e)
        {
            numMathCorrect.Leave += (s, e)
                => EnterNet(tbxMathNet, _examService.CheckAndCalculateNet(numMathCorrect.Value, numMathIncorrect.Value, 20).Item2);
            numMathIncorrect.Leave += (s, e)
                => EnterNet(tbxMathNet, _examService.CheckAndCalculateNet(numMathCorrect.Value, numMathIncorrect.Value, 20).Item2);

            numScienceCorrect.Leave += (s, e)
                => EnterNet(tbxScienceNet, _examService.CheckAndCalculateNet(numScienceCorrect.Value, numScienceIncorrect.Value, 20).Item2);
            numScienceIncorrect.Leave += (s, e)
                => EnterNet(tbxScienceNet, _examService.CheckAndCalculateNet(numScienceCorrect.Value, numScienceIncorrect.Value, 20).Item2);

            numTurkishCorrect.Leave += (s, e)
                => EnterNet(tbxTurkishNet, _examService.CheckAndCalculateNet(numTurkishCorrect.Value, numTurkishIncorrect.Value, 20).Item2);
            numTurkishIncorrect.Leave += (s, e)
                => EnterNet(tbxTurkishNet, _examService.CheckAndCalculateNet(numTurkishCorrect.Value, numTurkishIncorrect.Value, 20).Item2);

            numHistoryCorrect.Leave += (s, e)
                => EnterNet(tbxHistoryNet, _examService.CheckAndCalculateNet(numHistoryCorrect.Value, numHistoryIncorrect.Value, 10).Item2);
            numHistoryIncorrect.Leave += (s, e)
                => EnterNet(tbxHistoryNet, _examService.CheckAndCalculateNet(numHistoryCorrect.Value, numHistoryIncorrect.Value, 10).Item2);

            numReligionCorrect.Leave += (s, e)
                => EnterNet(tbxReligionNet, _examService.CheckAndCalculateNet(numReligionCorrect.Value, numReligionIncorrect.Value, 10).Item2);
            numReligionIncorrect.Leave += (s, e)
                => EnterNet(tbxReligionNet, _examService.CheckAndCalculateNet(numReligionCorrect.Value, numReligionIncorrect.Value, 10).Item2);

            numEnglishCorrect.Leave += (s, e)
                => EnterNet(tbxEnglishNet, _examService.CheckAndCalculateNet(numEnglishCorrect.Value, numEnglishIncorrect.Value, 10).Item2);
            numEnglishIncorrect.Leave += (s, e)
                => EnterNet(tbxEnglishNet, _examService.CheckAndCalculateNet(numEnglishCorrect.Value, numEnglishIncorrect.Value, 10).Item2);
        }

        private void EnterNet(TextBox tbx, string net)
        {
            tbx.Text = net;
        }
    }
}
