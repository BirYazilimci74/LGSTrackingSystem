using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Repositories.Repositories;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Pages
{
    public partial class LoginPage : Form
    {
        private readonly UserService _userService;
        private readonly StudentService _studentService;
        private readonly AdminService _adminService;

        public User? User { get; set; }
        public Student? Student { get; set; }
        public Admin? Admin { get; set; }

        public LoginPage()
        {
            _userService = new UserService();
            _studentService = new StudentService();
            _adminService = new AdminService();
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if(CheckEmptyFields()) return;

            await NavigateToMainPageAsync();
        }

        private async Task NavigateToMainPageAsync()
        {
            User = await _userService.CheckCredentialsAsync(tbxUsername.Text, tbxPassword.Text);

            if (User is not null)
            {
                Student = await _studentService.GetStudentByUserIdAsync(User.Id);

                if (Student != null)
                {
                    var studentPage = new StudentPage(Student);
                    studentPage.Show();
                    this.Hide();
                    return;
                }

                Admin = await _adminService.GetAdminByUserIdAsync(User.Id);

                if (Admin != null)
                {
                    var adminPage = new AdminPage(Admin);
                    adminPage.Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("User not found. Please try again.");
        }

        private bool CheckEmptyFields()
        {
            lblUsernameMsg.Text = string.IsNullOrWhiteSpace(tbxUsername.Text) ? "Cannot be empty" : string.Empty;
            lblPasswordMsg.Text = string.IsNullOrWhiteSpace(tbxPassword.Text) ? "Cannot be empty" : string.Empty;

            return string.IsNullOrWhiteSpace(tbxUsername.Text) || string.IsNullOrWhiteSpace(tbxPassword.Text);
        }
    }
}
