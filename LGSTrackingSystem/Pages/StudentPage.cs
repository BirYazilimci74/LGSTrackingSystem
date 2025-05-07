using LGSTrackingSystem.Domain.Interfaces;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Repositories;
using LGSTrackingSystem.Repositories.Repositories;
using LGSTrackingSystem.Services.Mappers;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Pages
{
    public partial class StudentPage : Form
    {
        private readonly IRepository<Student> _studentRepository;
        private Student _student { get; set; }
        
        public StudentPage(Student student)
        {
            InitializeComponent();
            _student = student;
            _studentRepository = new StudentRepository(new LGSTrackingDBContext());
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {
            this.Text = $"Welcome, {_student.FirstName} {_student.LastName}";
            dgwExamList.DataSource = _student.Exams?.Select(e => e.ToExamResultDTO()).ToList();
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            ExamPage examPage = new ExamPage(_student);
            examPage.ShowDialog();
        }
    }
}
