using LGSTrackingSystem.Domain.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace LGSTrackingSystem.Services.Services
{
    public class AdminService : Service<Admin>
    {
        public AdminService(LGSTrackingDBContext context) : base(context)
        {

        }

        public async Task<Admin> GetAdminByUserId(int userId)
        {
            return await _context.Admins.FirstOrDefaultAsync(a => a.UserId == userId);
        }
    }
}
