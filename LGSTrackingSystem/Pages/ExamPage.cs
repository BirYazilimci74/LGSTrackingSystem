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
            if (string.IsNullOrEmpty(tbxExamName.Text))
            {
                MessageBox.Show("Exam name cannot be empty.");
                return;
            }

            var mathCorrect = Convert.ToInt32(numMathCorrect.Value);
            var mathIncorrect = Convert.ToInt32(numMathIncorrect.Value);
            double? mathNet = 0;
            
            var scienceCorrect = Convert.ToInt32(numScienceCorrect.Value);
            var scienceIncorrect = Convert.ToInt32(numScienceIncorrect.Value);
            double? scienceNet = 0;
            
            var turkishCorrect = Convert.ToInt32(numTurkishCorrect.Value);
            var turkishIncorrect = Convert.ToInt32(numTurkishIncorrect.Value);
            double? turkishNet = 0;
            
            var historyCorrect = Convert.ToInt32(numHistoryCorrect.Value);
            var historyIncorrect = Convert.ToInt32(numHistoryIncorrect.Value);
            double? historyNet = 0;
            
            var religionCorrect = Convert.ToInt32(numReligionCorrect.Value);
            var religionIncorrect = Convert.ToInt32(numReligionIncorrect.Value);
            double? religionNet = 0;
            
            var englishCorrect = Convert.ToInt32(numEnglishCorrect.Value);
            var englishIncorrect = Convert.ToInt32(numEnglishIncorrect.Value);
            double? englishNet = 0;

            double? examScore = 0;
            double? totalNet = 0;

            if (!CalculateScore(ref mathNet, 
                           ref scienceNet, 
                           ref turkishNet, 
                           ref historyNet, 
                           ref religionNet, 
                           ref englishNet,
                           ref totalNet, 
                           ref examScore)) return;

            var newExam = new Exam
            {
                ExamDate = dtpExamDate.Value,
                ExamName = tbxExamName.Text,
                EnteredBy = _student is null ? "Admin" : "Student",

                MathCorrect = mathCorrect,
                MathIncorrect = mathIncorrect,
                MathEmpty = 20 - (mathCorrect + mathIncorrect),
                MathNet = mathNet ?? 0,

                ScienceCorrect = scienceCorrect,
                ScienceIncorrect = scienceIncorrect,
                ScienceEmpty = 20 - (scienceCorrect + scienceIncorrect),
                ScienceNet = scienceNet ?? 0,

                TurkishCorrect = turkishCorrect,
                TurkishIncorrect = turkishIncorrect,
                TurkishEmpty = 20 - (turkishCorrect + turkishIncorrect),
                TurkishNet = turkishNet ?? 0,

                HistoryCorrect = historyCorrect,
                HistoryIncorrect = historyIncorrect,
                HistoryEmpty = 10 - (historyCorrect + historyIncorrect),
                HistoryNet = historyNet ?? 0,

                ReligionCorrect = religionCorrect,
                ReligionIncorrect = religionIncorrect,
                ReligionEmpty = 10 - (religionCorrect + religionIncorrect),
                ReligionNet = religionNet ?? 0,

                EnglishCorrect = englishCorrect,
                EnglishIncorrect = englishIncorrect,
                EnglishEmpty = 10 - (englishCorrect + englishIncorrect),
                EnglishNet = englishNet ?? 0,

                TotalNet = totalNet ?? 0,
                Score = examScore ?? 0,
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
                => EnterNet(tbxMathNet, _examService.CheckAndCalculateNet(numMathCorrect.Value, numMathIncorrect.Value, 20));
            numMathIncorrect.Leave += (s, e)
                => EnterNet(tbxMathNet, _examService.CheckAndCalculateNet(numMathCorrect.Value, numMathIncorrect.Value, 20));

            numScienceCorrect.Leave += (s, e)
                => EnterNet(tbxScienceNet, _examService.CheckAndCalculateNet(numScienceCorrect.Value, numScienceIncorrect.Value, 20));
            numScienceIncorrect.Leave += (s, e)
                => EnterNet(tbxScienceNet, _examService.CheckAndCalculateNet(numScienceCorrect.Value, numScienceIncorrect.Value, 20));

            numTurkishCorrect.Leave += (s, e)
                => EnterNet(tbxTurkishNet, _examService.CheckAndCalculateNet(numTurkishCorrect.Value, numTurkishIncorrect.Value, 20));
            numTurkishIncorrect.Leave += (s, e)
                => EnterNet(tbxTurkishNet, _examService.CheckAndCalculateNet(numTurkishCorrect.Value, numTurkishIncorrect.Value, 20));

            numHistoryCorrect.Leave += (s, e)
                => EnterNet(tbxHistoryNet, _examService.CheckAndCalculateNet(numHistoryCorrect.Value, numHistoryIncorrect.Value, 10));
            numHistoryIncorrect.Leave += (s, e)
                => EnterNet(tbxHistoryNet, _examService.CheckAndCalculateNet(numHistoryCorrect.Value, numHistoryIncorrect.Value, 10));

            numReligionCorrect.Leave += (s, e)
                => EnterNet(tbxReligionNet, _examService.CheckAndCalculateNet(numReligionCorrect.Value, numReligionIncorrect.Value, 10));
            numReligionIncorrect.Leave += (s, e)
                => EnterNet(tbxReligionNet, _examService.CheckAndCalculateNet(numReligionCorrect.Value, numReligionIncorrect.Value, 10));

            numEnglishCorrect.Leave += (s, e)
                => EnterNet(tbxEnglishNet, _examService.CheckAndCalculateNet(numEnglishCorrect.Value, numEnglishIncorrect.Value, 10));
            numEnglishIncorrect.Leave += (s, e)
                => EnterNet(tbxEnglishNet, _examService.CheckAndCalculateNet(numEnglishCorrect.Value, numEnglishIncorrect.Value, 10));
        }

        private void EnterNet(TextBox tbx, double? net)
        {
            tbx.Text = net?.ToString("0.00") ?? "0.00";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var mathCorrect = Convert.ToInt32(numMathCorrect.Value);
            var mathIncorrect = Convert.ToInt32(numMathIncorrect.Value);
            double? mathNet = 0;

            var scienceCorrect = Convert.ToInt32(numScienceCorrect.Value);
            var scienceIncorrect = Convert.ToInt32(numScienceIncorrect.Value);
            double? scienceNet = 0;

            var turkishCorrect = Convert.ToInt32(numTurkishCorrect.Value);
            var turkishIncorrect = Convert.ToInt32(numTurkishIncorrect.Value);
            double? turkishNet = 0;

            var historyCorrect = Convert.ToInt32(numHistoryCorrect.Value);
            var historyIncorrect = Convert.ToInt32(numHistoryIncorrect.Value);
            double? historyNet = 0;

            var religionCorrect = Convert.ToInt32(numReligionCorrect.Value);
            var religionIncorrect = Convert.ToInt32(numReligionIncorrect.Value);
            double? religionNet = 0;

            var englishCorrect = Convert.ToInt32(numEnglishCorrect.Value);
            var englishIncorrect = Convert.ToInt32(numEnglishIncorrect.Value);
            double? englishNet = 0;

            double? examScore = 0;
            double? totalNet = 0;

            CalculateScore(ref mathNet,
                           ref scienceNet,
                           ref turkishNet,
                           ref historyNet,
                           ref religionNet,
                           ref englishNet,
                           ref totalNet,
                           ref examScore);
        }

        private bool CalculateScore(ref double? mathNet, 
                                    ref double? scienceNet, 
                                    ref double? turkishNet, 
                                    ref double? historyNet, 
                                    ref double? religionNet, 
                                    ref double? englishNet,
                                    ref double? totalNet,
                                    ref double? examScore)
        {
            lblMsg.Text = string.Empty;

            var mathCorrect = Convert.ToInt32(numMathCorrect.Value);
            var mathIncorrect = Convert.ToInt32(numMathIncorrect.Value);
            mathNet = _examService.CheckAndCalculateNet(mathCorrect, mathIncorrect, 20);
            if (mathNet is null)
            {
                lblMsg.Text += "\nTotal math question should be less that 20";
                return false;
            }

            var scienceCorrect = Convert.ToInt32(numScienceCorrect.Value);
            var scienceIncorrect = Convert.ToInt32(numScienceIncorrect.Value);
            scienceNet = _examService.CheckAndCalculateNet(scienceCorrect, scienceIncorrect, 20);
            if (scienceNet is null)
            {
                lblMsg.Text += "\nTotal science question should be less that 20";
                return false;
            }

            var turkishCorrect = Convert.ToInt32(numTurkishCorrect.Value);
            var turkishIncorrect = Convert.ToInt32(numTurkishIncorrect.Value);
            turkishNet = _examService.CheckAndCalculateNet(turkishCorrect, turkishIncorrect, 20);
            if (turkishNet is null)
            {
                lblMsg.Text += "\nTotal turkish question should be less that 20";
                return false;
            }

            var historyCorrect = Convert.ToInt32(numHistoryCorrect.Value);
            var historyIncorrect = Convert.ToInt32(numHistoryIncorrect.Value);
            historyNet = _examService.CheckAndCalculateNet(historyCorrect, historyIncorrect, 10);
            if (historyNet is null)
            {
                lblMsg.Text += "\nTotal history question should be less that 10";
                return false;
            }

            var religionCorrect = Convert.ToInt32(numReligionCorrect.Value);
            var religionIncorrect = Convert.ToInt32(numReligionIncorrect.Value);
            religionNet = _examService.CheckAndCalculateNet(religionCorrect, religionIncorrect, 10);
            if (religionNet is null)
            {
                lblMsg.Text += "\nTotal religion question should be less that 10";
                return false;
            }

            var englishCorrect = Convert.ToInt32(numEnglishCorrect.Value);
            var englishIncorrect = Convert.ToInt32(numEnglishIncorrect.Value);
            englishNet = _examService.CheckAndCalculateNet(englishCorrect, englishIncorrect, 10);
            if (englishNet is null)
            {
                lblMsg.Text += "\nTotal english question should be less that 10";
                return false;
            }

            var score = (mathNet * 4) +
                        (scienceNet * 4) +
                        (turkishNet * 4) +
                        (historyNet * 1) +
                        (religionNet * 1) +
                        (englishNet * 1);

            double maxScore = 270;
            examScore = score / maxScore * 500;
            totalNet = mathNet + scienceNet + turkishNet + historyNet + religionNet + englishNet;

            tbxTotalNet.Text = totalNet?.ToString("0.00") ?? "0.00";
            tbxScore.Text = examScore?.ToString("0.00") ?? "0.00";
            return true;
        }
    }
}
