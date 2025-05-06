using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Repositories;
using LGSTrackingSystem.Repositories.Repositories;
using LGSTrackingSystem.Services.Services;

namespace LGSTrackingSystem.Pages
{
    public partial class LoginPage : Form
    {
        private readonly IRepository<User> _userRepository = new UserRepository(new UserService(new Services.LGSTrackingDBContext()));
        private readonly IRepository<Student> _studentRepository = new StudentRepository(new StudentService(new Services.LGSTrackingDBContext()));
        private readonly IRepository<Admin> _adminRepository = new AdminRepository(new AdminService(new Services.LGSTrackingDBContext()));

        public User User { get; set; }
        public Student Student { get; set; }
        public Admin Admin { get; set; }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if(CheckEmptyFields()) return;

            await NavigateToMainPageAsync();
        }

        private async Task NavigateToMainPageAsync()
        {

            if (await CheckCredentialsAsync(tbxUsername.Text, tbxPassword.Text))
            {
                Student = _studentRepository is StudentRepository studentRepository
                    ? await studentRepository.GetStudentByUserIdAsync(User.Id)
                    : null;

                if (Student != null)
                {
                    var studentPage = new StudentPage(Student);
                    studentPage.Show();
                    this.Hide();
                    return;
                }

                Admin = _adminRepository is AdminRepository admniRepository
                    ? await admniRepository.GetAdminByUserIdAsync(User.Id)
                    : null;

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

        private async Task<bool> CheckCredentialsAsync(string username, string password)
        {
            User user = null;
            if (_userRepository is UserRepository repository)
                user = await repository.GetUserByUsernameAndPasswordAsync(username, password);
            if (user != null)
            {
                User = user;
                return username == user.Username && password == user.Password;
            }
                
            return false;
        }

        private bool CheckEmptyFields()
        {
            lblUsernameMsg.Text = string.IsNullOrWhiteSpace(tbxUsername.Text) ? "Cannot be empty" : string.Empty;
            lblPasswordMsg.Text = string.IsNullOrWhiteSpace(tbxPassword.Text) ? "Cannot be empty" : string.Empty;

            return string.IsNullOrWhiteSpace(tbxUsername.Text) || string.IsNullOrWhiteSpace(tbxPassword.Text);
        }
    }
}
