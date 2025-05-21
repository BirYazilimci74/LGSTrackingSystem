using LGSTrackingSystem.Core.DTOs;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Services;
using System.Text.RegularExpressions;

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
            tbxFirstName.Leave += (s, e) => CheckFields(s, e, lblFirstNameMsg);
            tbxLastName.Leave += (s, e) => CheckFields(s, e, lblLastNameMsg);
            tbxEmail.Leave += (s, e) => CheckFields(s, e, lblEmailMsg);
            msktbxPhone.Leave += (s, e) => CheckFields(s, e, lblPhoneMsg);
            tbxSchoolName.Leave += (s, e) => CheckFields(s, e, lblSchoolNameMsg);
            tbxClass.Leave += (s, e) => CheckFields(s, e, lblClassMsg);
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            if (string.Equals(this.Text, "Update Student"))
            {
                if (await UpdateStudentAsync(_studentId))
                {
                    MessageBox.Show("Student updated successfully.");
                    return;
                }
            }

            if (string.Equals(this.Text, "Add Student"))
            {
                if (!CheckFields()) return;

                if (AddStudent())
                {
                    MessageBox.Show("Student added successfully.");
                    return;
                }

            }
        }

        private bool AddStudent()
        {
            try
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
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }

        private async Task<bool> UpdateStudentAsync(int studentId)
        {
            try
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
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
            MessageBox.Show("Student not found.");
            return false;
        }

        private string GenerateUsername(string email) => email.Split('@')[0].ToLower();

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private bool CheckFields()
        {
            if (string.IsNullOrWhiteSpace(tbxFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbxLastName.Text) ||
                string.IsNullOrWhiteSpace(tbxEmail.Text) ||
                string.IsNullOrWhiteSpace(msktbxPhone.Text) ||
                string.IsNullOrWhiteSpace(tbxSchoolName.Text) ||
                string.IsNullOrWhiteSpace(tbxClass.Text))
            {
                return false;
            }
            return true;
        }

        private void tbxEmail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(tbxEmail.Text, pattern))
            {
                lblEmailMsg.Text = "Invalid email format";
            }
        }

        public void CheckFields(object sender, EventArgs e, Label label)
        {
            var textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                label.Text = "Can NOT be empty";
            }
        }
    }
}
