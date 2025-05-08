using LGSTrackingSystem.Core.DTOs;
using LGSTrackingSystem.Domain.Models;

namespace LGSTrackingSystem.Services.Mappers
{
    public static class StudentMapper
    {
        public static StudentResponseDTO ToStudentResponseDTO(this Student student)
        {
            return new StudentResponseDTO(
                student.FirstName,
                student.LastName,
                student.Email,
                student.PhoneNumber,
                student.SchoolName,
                student.Class,
                student.User,
                student.Exams
            );
        }
    }
}
