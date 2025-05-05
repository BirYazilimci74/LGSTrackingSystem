using LGSTrackingSystem.Domain.Models;

namespace LGSTrackingSystem.Services.Services
{
    public class ExamService : Service<Exam>
    {
        public ExamService(LGSTrackingDBContext context) : base(context)
        {

        }
    }
}
