﻿using LGSTrackingSystem.Core.DTOs;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Mappers;
using LGSTrackingSystem.Services.Services;
using LGSTrackingSystem.UI.Pages;

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

        private async void AdminPage_Load(object sender, EventArgs e)
        {
            this.Text = $"Welcome, {_admin.FirstName} {_admin.LastName}";
            await LoadStudents();
        }

        private async Task LoadStudents()
        {
            try
            {
                dgwStudentList.DataSource = null;
                _students = await _studentService.GetAllStudentsAsync();
                dgwStudentList.DataSource = _students.Select(s => s.ToStudentResponseDTO()).ToList();
                dgwStudentList.Columns["Id"].Visible = false;
                dgwStudentList.Columns["User"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Students could not list");
                throw;
            }
        }

        private async void addExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int studentId = Convert.ToInt32(dgwStudentList.CurrentRow?.Cells["Id"].Value);
            if (studentId == 0)
            {
                MessageBox.Show("Please select a student to add an exam.");
                return;
            }

            var student = await _studentService.GetStudentByIdAsync(studentId);
            if (student == null)
            {
                MessageBox.Show("Student not found.");
                return;
            }

            ExamPage examPage = new ExamPage(studentId);
            examPage.Text = "Add Exam";
            examPage.ShowDialog();
        }

        private async void editToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            var selectedStudent = dgwStudentList.CurrentRow?.DataBoundItem as StudentResponseDTO;
            if (selectedStudent == null)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            var manageStudentPage = new ManageStudentPage(selectedStudent);
            manageStudentPage.Text = "Update Student";
            manageStudentPage.ShowDialog();
            await LoadStudents();
        }

        private async void addStudentToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            var manageStudentPage = new ManageStudentPage();
            manageStudentPage.Text = "Add Student";
            manageStudentPage.ShowDialog();
            await LoadStudents();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgwStudentList.CurrentRow == null)
            {
                MessageBox.Show("Please select a student to view exams.");
                return;
            }
            int studentId = Convert.ToInt32(dgwStudentList.CurrentRow?.Cells["Id"].Value);

            ExamListPage examListPage = new ExamListPage(studentId);
            examListPage.Text = "Exam List";
            examListPage.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
    }
}
