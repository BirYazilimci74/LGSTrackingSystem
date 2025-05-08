using LGSTrackingSystem.Core.DTOs;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Mappers;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Pages
{
    public partial class AdminPage : Form
    {
        private readonly StudentService _studentService;
        private readonly Admin _admin;
        private List<Student>? _students;

        public AdminPage(Admin admin)
        {
            _admin = admin;
            _studentService = new StudentService();
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            this.Text = $"Welcome, {_admin.FirstName} {_admin.LastName}";
            LoadStudents();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var manageStudentPage = new ManageStudentPage();
            manageStudentPage.ShowDialog();
            LoadStudents();
        }

        private async void LoadStudents()
        {
            _students = await _studentService.GetAllStudentsAsync();
            dgwStudentList.DataSource = _students.Select(s => s.ToStudentResponseDTO()).ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedStudent = dgwStudentList.CurrentRow?.DataBoundItem as StudentResponseDTO;
            var manageStudentPage = new ManageStudentPage(selectedStudent);
            manageStudentPage.ShowDialog();
            LoadStudents();
        }
    }
}
