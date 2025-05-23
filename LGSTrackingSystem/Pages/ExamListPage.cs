using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Pages;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.UI.Pages
{
    public partial class ExamListPage : Form
    {
        private readonly ExamService _examService;
        private readonly StudentService _studentService;
        private readonly int _studentId;

        public ExamListPage(int studentId)
        {
            _studentId = studentId;
            _studentService = new StudentService();
            _examService = new ExamService();

            InitializeComponent();
        }

        private async void addExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var _student = await _studentService.GetStudentByIdAsync(_studentId);
                if (_student is null)
                {
                    MessageBox.Show("Select a student to add an exam");
                    return;
                }

                ExamPage examPage = new ExamPage(_student);
                examPage.Text = "Add Exam";
                examPage.ShowDialog();
                await LoadExams();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void editExamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void deleteExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var examId = Convert.ToInt32(dgwExamList.CurrentRow?.Cells["Id"].Value);
            if (examId == 0)
            {
                MessageBox.Show("Select an exam to delete");
                return;
            }

            try
            {
                var exam = await _examService.GetByIdAsync(examId);
                if (exam is null)
                {
                    MessageBox.Show("Exam not found");
                    return;
                }

                _examService.DeleteExam(exam);
                await LoadExams();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async void ExamListPage_Load(object sender, EventArgs e)
        {
            try
            {
                var _student = await _studentService.GetStudentByIdAsync(_studentId);
                this.Text = $"Exam List for {_student?.FirstName} {_student?.LastName}";
            }
            catch (Exception)
            {
                MessageBox.Show("Student could not found");
                throw;
            }
            await LoadExams();
        }

        private async Task LoadExams()
        {
            try
            {
                dgwExamList.DataSource = null;
                var exams = await _studentService.GetExamsFromStudent(_studentId);
                var examsToShow = exams.Select(e => new
                {
                    e.Id,
                    e.ExamDate,
                    e.ExamName,
                    e.TotalNet,
                    e.Score
                }).ToList();
                dgwExamList.DataSource = examsToShow;
                dgwExamList.Columns["Id"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Exams could not list");
                throw;
            }
        }

        private async void dgwExamList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var examId = Convert.ToInt32(dgwExamList.Rows[e.RowIndex].Cells["Id"].Value);
                var exam = await _examService.GetByIdAsync(examId);
                if (exam is null)
                {
                    MessageBox.Show("Exam not found");
                    return;
                }
                FillExam(exam);
            }
        }

        private void FillExam(Exam exam)
        {
            lblExamName.Text = exam.ExamName;
            lblExamDate.Text = exam.ExamDate.ToString("dd/MM/yyyy");
            
            lblMathCorrect.Text = exam.MathCorrect.ToString();
            lblMathIncorrect.Text = exam.MathIncorrect.ToString();
            
            lblScienceCorrect.Text = exam.ScienceCorrect.ToString();
            lblScienceIncorrect.Text = exam.ScienceIncorrect.ToString();
            
            lblTurkishCorrect.Text = exam.TurkishCorrect.ToString();
            lblTurkishIncorrect.Text = exam.TurkishIncorrect.ToString();
            
            lblHistoryCorrect.Text = exam.HistoryCorrect.ToString();
            lblHistoryIncorrect.Text = exam.HistoryIncorrect.ToString();
            
            lblReligionCorrect.Text = exam.ReligionCorrect.ToString();
            lblReligionIncorrect.Text = exam.ReligionIncorrect.ToString();
            
            lblEnglishCorrect.Text = exam.EnglishCorrect.ToString();
            lblEnglishIncorrect.Text = exam.EnglishIncorrect.ToString();
            
            lblTotalNet.Text = exam.TotalNet.ToString();
            lblScore.Text = exam.Score.ToString();
        }
    }
}
