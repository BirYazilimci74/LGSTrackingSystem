using LGSTrackingSystem.Domain.Models;

namespace LGSTrackingSystem.Core.DTOs
{
    public record StudentResponseDTO(
        int Id,
        string FirstName,
        string LastName,
        string Email,
        string PhoneNumber,
        string SchoolName,
        string Class,
        User User,
        List<Exam> Exams
    );

}
