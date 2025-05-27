using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Services.Mappers;
using LGSTrackingSystem.Services.Services;
using LiveCharts;
using LiveCharts.Wpf;

namespace LGSTrackingSystem.Pages
{
    public partial class StudentPage : Form
    {
        private readonly StudentService _studentService;
        private readonly ExamService _examService;
        private Student _student { get; set; }
        private List<Exam>? _exams { get; set; }
        public StudentPage(Student student)
        {
            _student = student;
            _studentService = new StudentService();
            _examService = new ExamService();
            InitializeComponent();
        }

        private async void StudentPage_Load(object sender, EventArgs e)
        {
            this.Text = $"Welcome, {_student.FirstName} {_student.LastName}";
            await LoadExamResults();
            await LoadChartData();
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
            var labels = chartData.Select(e => e.ExamDate.ToString("dd/MM/yyyy")).ToList();

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
            var exams = await _studentService.GetExamsFromStudent(_student.Id);
            if (exams == null || !exams.Any())
            {
                MessageBox.Show("No exams found for this student.");
                return;
            }

            var chartData = exams
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
            var labels = chartData.Select(e => e.ExamDate.ToString("dd/MM/yyyy")).ToList();

            bool anyChecked = chbxDisplayMath.Checked == true ||
                             chbxDisplayScience.Checked == true ||
                             chbxDisplayTurkish.Checked == true ||
                             chbxDisplayHistory.Checked == true ||
                             chbxDisplayReligion.Checked == true ||
                             chbxDisplayEnglish.Checked == true;

            bool showMath = !anyChecked || chbxDisplayMath.Checked == true;
            bool showScience = !anyChecked || chbxDisplayScience.Checked == true;
            bool showTurkish = !anyChecked || chbxDisplayTurkish.Checked == true;
            bool showHistory = !anyChecked || chbxDisplayHistory.Checked == true;
            bool showReligion = !anyChecked || chbxDisplayReligion.Checked == true;
            bool showEnglish = !anyChecked || chbxDisplayEnglish.Checked == true;

            var allVisibleValues = new List<double>();
            if (showMath) allVisibleValues.AddRange(valuesMath);
            if (showScience) allVisibleValues.AddRange(valuesScience);
            if (showTurkish) allVisibleValues.AddRange(valuesTurkish);
            if (showHistory) allVisibleValues.AddRange(valuesHistory);
            if (showReligion) allVisibleValues.AddRange(valuesReligion);
            if (showEnglish) allVisibleValues.AddRange(valuesEnglish);

            var maxValue = allVisibleValues.Any() ? allVisibleValues.Max() : 0;
            var maxYAxis = Math.Min(90, (int)(Math.Ceiling(maxValue / 5.0) * 5));
            var minValue = allVisibleValues.Any() ? allVisibleValues.Min() : 0;
            var minYAxis = Math.Min(0, (int)(Math.Floor(minValue / 5.0) * 5));

            var seriesCollection = new SeriesCollection();

            if (showMath)
            {
                seriesCollection.Add(new LineSeries
                {
                    Title = "Math",
                    Values = new ChartValues<double>(valuesMath),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2,
                    Stroke = System.Windows.Media.Brushes.Blue,
                });
            }

            if (showScience)
            {
                seriesCollection.Add(new LineSeries
                {
                    Title = "Science",
                    Values = new ChartValues<double>(valuesScience),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2,
                    Stroke = System.Windows.Media.Brushes.LightGreen,
                });
            }

            if (showTurkish)
            {
                seriesCollection.Add(new LineSeries
                {
                    Title = "Turkish",
                    Values = new ChartValues<double>(valuesTurkish),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2,
                    Stroke = System.Windows.Media.Brushes.Orange,
                });
            }

            if (showHistory)
            {
                seriesCollection.Add(new LineSeries
                {
                    Title = "History",
                    Values = new ChartValues<double>(valuesHistory),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2,
                    Stroke = System.Windows.Media.Brushes.Brown,
                });
            }

            if (showReligion)
            {
                seriesCollection.Add(new LineSeries
                {
                    Title = "Religion",
                    Values = new ChartValues<double>(valuesReligion),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2,
                    Stroke = System.Windows.Media.Brushes.DarkGreen,
                });
            }

            if (showEnglish)
            {
                seriesCollection.Add(new LineSeries
                {
                    Title = "English",
                    Values = new ChartValues<double>(valuesEnglish),
                    LineSmoothness = 0.3,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    StrokeThickness = 2,
                    Stroke = System.Windows.Media.Brushes.Pink,
                });
            }

            chartLesson.Series = seriesCollection;

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
                    Title = "Net Score",
                    MaxValue = maxYAxis,
                    MinValue = minYAxis,
                    Separator = new Separator
                    {
                        Step = 2,
                        IsEnabled = true
                    }
                }
            };
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var pathToPDF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                if (dgwExamList.CurrentRow is null)
                {
                    MessageBox.Show("Select an exam to export");
                    return;
                }
                var examId = Convert.ToInt32(dgwExamList.CurrentRow.Cells["Id"].Value);
                if (examId == 0)
                {
                    MessageBox.Show("Select an exam to export");
                    return;
                }
                var exam = await _examService.GetByIdAsync(examId);
                _examService.ExportPDF(exam, pathToPDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exam could not exported to PDF. \n{ex}");
                throw;
            }
            MessageBox.Show("Exam exported successfully to PDF. Check your desktop for the file.");
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

        private async void chbxDisplayMath_CheckedChanged(object sender, EventArgs e) => await LessionChart();

        private async void chbxDisplayScience_CheckedChanged(object sender, EventArgs e) => await LessionChart();

        private async void chbxDisplayTurkish_CheckedChanged(object sender, EventArgs e) => await LessionChart();

        private async void chbxDisplayHistory_CheckedChanged(object sender, EventArgs e) => await LessionChart();

        private async void chbxDisplayReligion_CheckedChanged(object sender, EventArgs e) => await LessionChart();

        private async void chbxDisplayEnglish_CheckedChanged(object sender, EventArgs e) => await LessionChart();
    }
}
