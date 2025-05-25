using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Mappers;
using LGSTrackingSystem.Services.Services;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace LGSTrackingSystem.Pages
{
    public partial class StudentPage : Form
    {
        private readonly StudentService _studentService;
        private Student _student { get; set; }
        private List<Exam>? _exams { get; set; }
        public StudentPage(Student student)
        {
            InitializeComponent();
            _student = student;
            _studentService = new StudentService();
        }

        private async void StudentPage_Load(object sender, EventArgs e)
        {
            this.Text = $"Welcome, {_student.FirstName} {_student.LastName}";
            await LoadExamResults();
            await LoadChartData();
        }

        private async void btnAddExam_Click(object sender, EventArgs e)
        {
            ExamPage examPage = new ExamPage(_student);
            examPage.ShowDialog();
            await LoadExamResults();
        }

        private async Task LoadExamResults()
        {
            try
            {
                _exams = await _studentService.GetExamsFromStudent(_student.Id);
                dgwExamList.DataSource = _exams.Select(e => e.ToExamResultDTO()).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Exams could not list");
                throw;
            }
        }

        private async Task LoadChartData()
        {
            await GeneralChart();
            await LessionChart();
        }

        private async Task GeneralChart()
        {
            _exams = await _studentService.GetExamsFromStudent(_student.Id);

            if (_exams == null || !_exams.Any())
            {
                MessageBox.Show("No exams found for this student.");
                return;
            }

            var chartData = _exams
                .OrderBy(e => e.ExamDate)
                .Select(e => new
                {
                    ExamDate = e.ExamDate,
                    TotalNet = e.TotalNet
                }).ToList();

            var values = chartData.Select(e => e.TotalNet).ToArray();
            var labels = chartData.Select(e => e.ExamDate.ToString("dd/MM")).ToList();

            chartGeneral.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Net",
                    Values = new ChartValues<double>(values),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2
                }
            };

            chartGeneral.AxisX = new AxesCollection
            {
                new Axis
                {
                    Labels = labels,
                    Title = "Exam Date",
                    LabelsRotation = 15
                }
            };

            chartGeneral.AxisY = new AxesCollection
            {
                new Axis
                {
                    Labels = new List<string> {"5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90"},
                    Title = "Total Net",
                }
            };
        }

        private async Task LessionChart()
        {
            _exams = await _studentService.GetExamsFromStudent(_student.Id);

            if (_exams == null || !_exams.Any())
            {
                MessageBox.Show("No exams found for this student.");
                return;
            }

            var chartData = _exams
                .OrderBy(e => e.ExamDate)
                .Select(e => new
                {
                    ExamDate = e.ExamDate,
                    MathNet = e.MathNet,
                    ScienceNet = e.ScienceNet,
                    TurkishNet = e.TurkishNet,
                    HistoryNet = e.HistoryNet,
                    ReligionNet = e.ReligionNet,
                    EnglishNet = e.EnglishNet
                }).ToList();

            var valuesMath = chartData.Select(e => e.MathNet).ToArray();
            var valuesScience = chartData.Select(e => e.ScienceNet).ToArray();
            var valuesTurkish = chartData.Select(e => e.TurkishNet).ToArray();
            var valuesHistory = chartData.Select(e => e.HistoryNet).ToArray();
            var valuesReligion = chartData.Select(e => e.ReligionNet).ToArray();
            var valuesEnglish = chartData.Select(e => e.EnglishNet).ToArray();
            var labels = chartData.Select(e => e.ExamDate.ToString("dd/MM")).ToList();

            chartLesson.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Net",
                    Values = new ChartValues<double>(valuesMath),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2
                },

                new LineSeries
                {
                    Title = "Net",
                    Values = new ChartValues<double>(valuesScience),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2
                },

                new LineSeries
                {
                    Title = "Net",
                    Values = new ChartValues<double>(valuesTurkish),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2
                },

                new LineSeries
                {
                    Title = "Net",
                    Values = new ChartValues<double>(valuesHistory),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2
                },

                new LineSeries
                {
                    Title = "Net",
                    Values = new ChartValues<double>(valuesReligion),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2
                },

                new LineSeries
                {
                    Title = "Net",
                    Values = new ChartValues<double>(valuesEnglish),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2
                }
            };

            chartLesson.AxisX = new AxesCollection
            {
                new Axis
                {
                    Labels = labels,
                    Title = "Exam Date",
                    LabelsRotation = 15
                }
            };

            chartLesson.AxisY = new AxesCollection
            {
                new Axis
                {
                    Labels = new List<string> {"5", "10", "15", "20"},
                    Title = "Total Net",
                }
            };
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private async void addExamToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            ExamPage examPage = new ExamPage(_student);
            examPage.ShowDialog();
            await LoadExamResults();
        }
    }
}
