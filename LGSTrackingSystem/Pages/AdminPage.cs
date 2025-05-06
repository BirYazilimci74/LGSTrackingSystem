using LGSTrackingSystem.Domain.Models;
using System.Windows.Forms;

namespace LGSTrackingSystem.Pages
{
    public partial class AdminPage : Form
    {
        private readonly Admin _admin;
        public AdminPage(Admin admin)
        {
            _admin = admin;
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, System.EventArgs e)
        {
            label1.Text = $"Welcome, {_admin.FirstName} {_admin.LastName}";
        }
    }
}
