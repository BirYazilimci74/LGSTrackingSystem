using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Pages;
using LGSTrackingSystem.Services.Services;
using LiveCharts.Wpf;
using LiveCharts;

namespace LGSTrackingSystem.UI.Pages
{
    public partial class ExamListPage : Form
    {
        private readonly ExamService _examService;
        private readonly StudentService _studentService;
        private readonly int _studentId;

        public ExamListPage(int studentId)
        {
            _studentId = studentId;
            _studentService = new StudentService();
            _examService = new ExamService();

            InitializeComponent();
        }

        private async void ExamListPage_Load(object sender, EventArgs e)
        {
            try
            {
                var _student = await _studentService.GetStudentByIdAsync(_studentId);
                this.Text = $"{_student?.FirstName} {_student?.LastName}'s Exams";
            }
            catch (Exception)
            {
                MessageBox.Show("Student could not found");
                throw;
            }
            await LoadExams();
            await LoadChartData();
        }

        private async void addExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var _student = await _studentService.GetStudentByIdAsync(_studentId);
                if (_student is null)
                {
                    MessageBox.Show("Select a student to add an exam");
                    return;
                }

                ExamPage examPage = new ExamPage(_student);
                examPage.Text = "Add Exam";
                examPage.ShowDialog();
                await LoadExams();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void editExamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void deleteExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var examId = Convert.ToInt32(dgwExamList.CurrentRow?.Cells["Id"].Value);
            if (examId == 0)
            {
                MessageBox.Show("Select an exam to delete");
                return;
            }

            try
            {
                var exam = await _examService.GetByIdAsync(examId);
                if (exam is null)
                {
                    MessageBox.Show("Exam not found");
                    return;
                }

                _examService.DeleteExam(exam);
                await LoadExams();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async void dgwExamList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var examId = Convert.ToInt32(dgwExamList.Rows[e.RowIndex].Cells["Id"].Value);
                var exam = await _examService.GetByIdAsync(examId);
                if (exam is null)
                {
                    MessageBox.Show("Exam not found");
                    return;
                }
                FillExam(exam);
            }
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

        private void FillExam(Exam exam)
        {
            lblExamName.Text = exam.ExamName;
            lblExamDate.Text = exam.ExamDate.ToString("dd/MM/yyyy");

            lblMathCorrect.Text = exam.MathCorrect.ToString();
            lblMathIncorrect.Text = exam.MathIncorrect.ToString();

            lblScienceCorrect.Text = exam.ScienceCorrect.ToString();
            lblScienceIncorrect.Text = exam.ScienceIncorrect.ToString();

            lblTurkishCorrect.Text = exam.TurkishCorrect.ToString();
            lblTurkishIncorrect.Text = exam.TurkishIncorrect.ToString();

            lblHistoryCorrect.Text = exam.HistoryCorrect.ToString();
            lblHistoryIncorrect.Text = exam.HistoryIncorrect.ToString();

            lblReligionCorrect.Text = exam.ReligionCorrect.ToString();
            lblReligionIncorrect.Text = exam.ReligionIncorrect.ToString();

            lblEnglishCorrect.Text = exam.EnglishCorrect.ToString();
            lblEnglishIncorrect.Text = exam.EnglishIncorrect.ToString();

            lblTotalNet.Text = exam.TotalNet.ToString();
            lblScore.Text = exam.Score.ToString();
        }

        private async Task LoadExams()
        {
            try
            {
                dgwExamList.DataSource = null;
                var exams = await _studentService.GetExamsFromStudent(_studentId);
                var examsToShow = exams.Select(e => new
                {
                    e.Id,
                    e.ExamDate,
                    e.ExamName,
                    e.TotalNet,
                    e.Score
                }).ToList();
                dgwExamList.DataSource = examsToShow;
                dgwExamList.Columns["Id"].Visible = false;
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
            var exams = await _studentService.GetExamsFromStudent(_studentId);
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
                    TotalNet = e.TotalNet
                }).ToList();

            var values = chartData.Select(e => e.TotalNet).ToArray();
            var labels = chartData.Select(e => e.ExamDate.ToString("dd/MM/yyyy")).ToList();

            var maxValue = values.Max();
            var maxYAxis = Math.Min(90, (int)(Math.Ceiling(maxValue / 5.0) * 5));

            var yLabels = new List<string>();
            for (int i = 0; i <= maxYAxis; i += 5)
            {
                yLabels.Add(i.ToString());
            }

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
                    Title = "Total Net",
                    MaxValue = maxYAxis,
                    MinValue = 0,
                    LabelFormatter = value => value.ToString(),
                    Separator = new Separator
                    {
                        Step = 5,
                        IsEnabled = true
                    }
                }
            };
        }

        private async Task LessionChart()
        {
            var exams = await _studentService.GetExamsFromStudent(_studentId);
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

        private async void chbxDisplayMath_CheckedChanged(object sender, EventArgs e) => await LessionChart();

        private async void chbxDisplayScience_CheckedChangedAsync(object sender, EventArgs e) => await LessionChart();

        private async void chbxDisplayTurkish_CheckedChangedAsync(object sender, EventArgs e) => await LessionChart();

        private async void chbxDisplayHistory_CheckedChangedAsync(object sender, EventArgs e) => await LessionChart();

        private async void chbxDisplayReligion_CheckedChangedAsync(object sender, EventArgs e) => await LessionChart();

        private async void chbxDisplayEnglish_CheckedChangedAsync(object sender, EventArgs e) => await LessionChart();
    }
}
