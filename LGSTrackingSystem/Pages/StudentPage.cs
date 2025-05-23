using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Mappers;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Pages
{
    public partial class StudentPage : Form
    {
        private readonly StudentService _studentService;
        private Student _student { get; set; }
        private List<Exam>? _exams { get; set; }
        public StudentPage(Student student)
        {
            InitializeComponent();
            _student = student;
            _studentService = new StudentService();
        }

        private async void StudentPage_Load(object sender, EventArgs e)
        {
            this.Text = $"Welcome, {_student.FirstName} {_student.LastName}";
            await LoadExamResults();
        }

        private async void btnAddExam_Click(object sender, EventArgs e)
        {
            ExamPage examPage = new ExamPage(_student);
            examPage.ShowDialog();
            await LoadExamResults();
        }

        private async Task LoadExamResults()
        {
            try
            {
                _exams = await _studentService.GetExamsFromStudent(_student.Id);
                dgwExamList.DataSource = _exams.Select(e => e.ToExamResultDTO()).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Exams could not list");
                throw;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private async void addExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExamPage examPage = new ExamPage(_student);
            examPage.ShowDialog();
            await LoadExamResults();
        }
    }
}
