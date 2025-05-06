using LGSTrackingSystem.Domain.Models;
using System.Windows.Forms;

namespace LGSTrackingSystem.Pages
{
    public partial class StudentPage : Form
    {
        private readonly Student _student;
        public StudentPage(Student student)
        {
            _student = student;
            InitializeComponent();
        }

        private void StudentPage_Load(object sender, System.EventArgs e)
        {
            label1.Text = $"Welcome, {_student.FirstName} {_student.LastName}";
        }
    }
}
