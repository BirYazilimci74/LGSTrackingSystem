using LGSTrackingSystem.Domain.Models;

namespace LGSTrackingSystem.Services.Services
{
    public class StudentService : Service<Student>
    {
        public StudentService(LGSTrackingDBContext context) : base(context)
        {

        }
    }
}
