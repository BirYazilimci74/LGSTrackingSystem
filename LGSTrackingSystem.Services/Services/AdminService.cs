using LGSTrackingSystem.Domain.Models;

namespace LGSTrackingSystem.Services.Services
{
    public class AdminService : Service<Admin>
    {
        public AdminService(LGSTrackingDBContext context) : base(context)
        {

        }
    }
}
