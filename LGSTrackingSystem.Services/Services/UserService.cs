using LGSTrackingSystem.Domain.Models;

namespace LGSTrackingSystem.Services.Services
{
    public class UserService : Service<User>
    {
        public UserService(LGSTrackingDBContext context) : base(context)
        {

        }
    }
}
