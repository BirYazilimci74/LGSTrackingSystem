using LGSTrackingSystem.Core.DTOs;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Pages
{
    public partial class ManageStudentPage : Form
    {
        private readonly StudentService _studentService;
        private readonly UserService _userService;
        private int _studentId;

        public ManageStudentPage()
        {
            _userService = new UserService();
            _studentService = new StudentService();
            InitializeComponent();
        }

        public ManageStudentPage(StudentResponseDTO student)
        {
            _studentId = student.Id;
            _userService = new UserService();
            _studentService = new StudentService();
            InitializeComponent();
            tbxFirstName.Text = student.FirstName;
            tbxLastName.Text = student.LastName;
            tbxEmail.Text = student.Email;
            msktbxPhone.Text = student.PhoneNumber;
            tbxSchoolName.Text = student.SchoolName;
            tbxClass.Text = student.Class;
        }

        private void ManageStudentPage_Load(object sender, EventArgs e)
        {

        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (string.Equals(this.Text, "Update Student"))
            {
                await UpdateStudentAsync(_studentId);
                MessageBox.Show("Student updated successfully.");
                return;
            }

            if (string.Equals(this.Text, "Add Student"))
            {
                AddStudent();
                MessageBox.Show("Student added successfully.");
                return;
            }
        }

        private void AddStudent()
        {
            var newUser = new User()
            {
                Username = GenerateUsername(tbxEmail.Text),
                Password = tbxFirstName.Text.ToLower(),
                Role = "Student"
            };

            var userId = _userService.AddUser(newUser);

            var newStudent = new Student()
            {
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text,
                Email = tbxEmail.Text,
                PhoneNumber = msktbxPhone.Text,
                SchoolName = tbxSchoolName.Text,
                Class = tbxClass.Text,
                UserId = userId,
            };

            _studentService.AddStudent(newStudent);
        }

        private async Task UpdateStudentAsync(int studentId)
        {
            var existingStudent = await _studentService.GetStudentByIdAsync(studentId);

            if (existingStudent is not null)
            {
                existingStudent.FirstName = tbxFirstName.Text;
                existingStudent.LastName = tbxLastName.Text;
                existingStudent.Email = tbxEmail.Text;
                existingStudent.PhoneNumber = msktbxPhone.Text;
                existingStudent.SchoolName = tbxSchoolName.Text;
                existingStudent.Class = tbxClass.Text;

                await _studentService.UpdateStudentAsync(studentId, existingStudent);
                return;
            }
            MessageBox.Show("Student not found.");
        }

        private string GenerateUsername(string email) => email.Split('@')[0].ToLower();

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    }
}
