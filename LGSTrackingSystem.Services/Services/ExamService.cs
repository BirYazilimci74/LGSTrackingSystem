using LGSTrackingSystem.Domain.Interfaces;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Repositories;
using LGSTrackingSystem.Repositories.Repositories;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace LGSTrackingSystem.Services.Services
{
    public class ExamService
    {
        private readonly IRepository<Exam> _examRepository;

        public ExamService()
        {
            _examRepository = new ExamRepository(new LGSTrackingDBContext());
        }

        public void AddExamToStudent(Student student, Exam newExam)
        {
            if (_examRepository is ExamRepository repository)
                repository.AddExamToStudentAsync(student, newExam);
        }

        public void DeleteExam(Exam exam)
        {
            if (exam is not null)
            {
                _examRepository.Delete(exam);
                return;
            }
        }

        public async Task<Exam> GetByIdAsync(int id)
        {
            var exam = await _examRepository.GetByIdAsync(id);
            if (exam is null)
                throw new Exception("Exam not found");
            return exam;
        }

        public double? CheckAndCalculateNet(decimal correct, decimal incorrect, int maxNet)
        {
            if (correct + incorrect > maxNet)
            {
                return null;
            }
            var net = ((double)correct - ((double)incorrect / 3 + ((double)incorrect % 3) * 0.33));
            return net;
        }

        public void ExportPDF(Exam exam, string path)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            var doc = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(11));
                    page.PageColor(Colors.White);

                    page.Header().AlignCenter().Text(exam.ExamName).SemiBold().FontSize(16);

                    page.Content().Column(column =>
                    {
                        column.Spacing(20);
                        column.Item().AlignCenter().Text($"Tarih: {exam.ExamDate:dd.MM.yyyy}");

                        column.Item().AlignCenter().Element(container =>
                        {
                            container.Border(1).Background("#F0F8FF").MaxWidth(400).Padding(0).Column(inner =>
                            {
                                inner.Item().PaddingTop(0).Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn();
                                        columns.RelativeColumn();
                                    });

                                    table.Cell().Element(CellStyle).Text("Student Name:").Bold();
                                    table.Cell().Background(Colors.White).Element(CellStyle).Text($"{exam.Student.FirstName} {exam.Student.LastName}");
                                });

                                inner.Item().PaddingBottom(0).Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn();
                                        columns.RelativeColumn();
                                        columns.RelativeColumn();
                                        columns.RelativeColumn();
                                    });

                                    table.Cell().Element(CellStyle).Text("School:").Bold();
                                    table.Cell().Background(Colors.White).Element(CellStyle).Text(exam.Student.SchoolName.ToString());
                                    table.Cell().Element(CellStyle).Text("Class:").Bold();
                                    table.Cell().Background(Colors.White).Element(CellStyle).Text(exam.Student.Class.ToString());
                                });
                            });
                        });

                        Action<IContainer> CreateLessonTable(string title, int correct, int incorrect, int blank, double net)
                        {
                            return container =>
                            {
                                container.Border(1).Padding(0).Background("#F0F8FF").Column(inner =>
                                {
                                    inner.Item().Padding(5).AlignCenter().Text(title).Bold().FontSize(12).FontColor(Colors.Black);

                                    inner.Item().Table(table =>
                                    {
                                        table.ColumnsDefinition(columns =>
                                        {
                                            columns.RelativeColumn();
                                            columns.RelativeColumn();
                                            columns.RelativeColumn();
                                            columns.RelativeColumn();
                                        });

                                        table.Header(header =>
                                        {
                                            header.Cell().Element(CellStyle).Text("Correct").Bold();
                                            header.Cell().Element(CellStyle).Text("Incorrect").Bold();
                                            header.Cell().Element(CellStyle).Text("Blank").Bold();
                                            header.Cell().Element(CellStyle).Text("Net").Bold();
                                        });

                                        table.Cell().Background(Colors.White).Element(CellStyle).Text(correct.ToString());
                                        table.Cell().Background(Colors.White).Element(CellStyle).Text(incorrect.ToString());
                                        table.Cell().Background(Colors.White).Element(CellStyle).Text(blank.ToString());
                                        table.Cell().Background(Colors.White).Element(CellStyle).Text($"{net:0.00}");
                                    });
                                });
                            };
                        }

                        void AddTwoLessonsRow(string t1, int c1, int i1, int b1, double n1,
                                              string t2, int c2, int i2, int b2, double n2)
                        {
                            column.Item().Row(row =>
                            {
                                row.RelativeColumn().Element(CreateLessonTable(t1, c1, i1, b1, n1));
                                row.Spacing(20);
                                row.RelativeColumn().Element(CreateLessonTable(t2, c2, i2, b2, n2));
                            });
                        }

                        AddTwoLessonsRow("Math", exam.MathCorrect, exam.MathIncorrect, exam.MathEmpty, exam.MathNet,
                                         "Science", exam.ScienceCorrect, exam.ScienceIncorrect, exam.ScienceEmpty, exam.ScienceNet);

                        AddTwoLessonsRow("Turkish", exam.TurkishCorrect, exam.TurkishIncorrect, exam.TurkishEmpty, exam.TurkishNet,
                                         "History", exam.HistoryCorrect, exam.HistoryIncorrect, exam.HistoryEmpty, exam.HistoryNet);

                        AddTwoLessonsRow("Religion", exam.ReligionCorrect, exam.ReligionIncorrect, exam.ReligionEmpty, exam.ReligionNet,
                                         "English", exam.EnglishCorrect, exam.EnglishIncorrect, exam.EnglishEmpty, exam.EnglishNet);

                        column.Item().PaddingTop(20).AlignCenter().Element(container =>
                        {
                            container.Border(1).Background("#F0F8FF").MaxWidth(400).Padding(0).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                    columns.RelativeColumn();
                                });

                                table.Cell().Element(CellStyle).Text("Total Net:").Bold();
                                table.Cell().Background(Colors.White).Element(CellStyle).Text($"{exam.TotalNet:0.00}");
                                table.Cell().Element(CellStyle).Text("Score:").Bold();
                                table.Cell().Background(Colors.White).Element(CellStyle).Text($"{exam.Score:0.00}");
                            });
                        });
                    });

                    page.Footer().AlignCenter().Text($"Prapered by {exam.EnteredBy}");

                    IContainer CellStyle(IContainer container) => container.Border(1).Padding(5).AlignCenter();
                });
            });
            doc.GeneratePdf($"{path}/{exam.Student.FirstName}_Exam_{exam.ExamName}_{exam.ExamDate:dd_MM_yyyy}.pdf");

        }
    }
}
