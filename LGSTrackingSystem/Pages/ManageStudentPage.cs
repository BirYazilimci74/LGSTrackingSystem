using LGSTrackingSystem.Core.DTOs;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Pages
{
    public partial class ManageStudentPage : Form
    {
        private readonly StudentService _studentService;
        private readonly UserService _userService;

        public ManageStudentPage()
        {
            _userService = new UserService();
            _studentService = new StudentService();
            InitializeComponent();
        }

        public ManageStudentPage(StudentResponseDTO student)
        {
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

        private void btnOK_Click(object sender, EventArgs e)
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

        private string GenerateUsername(string email)
        {
            var username = email.Split('@')[0].ToLower();
            return username;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
