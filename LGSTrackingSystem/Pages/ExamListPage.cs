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
            var _student = await _studentService.GetStudentByIdAsync(_studentId);
            ExamPage examPage = new ExamPage(_student);
            examPage.Text = "Add Exam";
            examPage.ShowDialog();
            await LoadExams();
        }

        private void editExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private async void deleteExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var examId = Convert.ToInt32(dgwExamList.CurrentRow?.Cells["Id"].Value);
            var exam = await _examService.GetByIdAsync(examId);
            _examService.DeleteExam(exam);
            await LoadExams();
        }

        private async void ExamListPage_Load(object sender, EventArgs e)
        {
            var _student = await _studentService.GetStudentByIdAsync(_studentId);
            this.Text = $"Exam List for {_student?.FirstName} {_student?.LastName}";
            await LoadExams();
        }

        private async Task LoadExams()
        {
            dgwExamList.DataSource = null;
            var exams = await _studentService.GetExamsFromStudent(_studentId);
            dgwExamList.DataSource = exams;
            dgwExamList.Columns["Id"].Visible = false;
            dgwExamList.Columns["Student"].Visible = false;
            dgwExamList.Columns["StudentId"].Visible = false;
        }
    }
}
