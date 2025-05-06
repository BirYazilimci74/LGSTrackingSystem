using LGSTrackingSystem.Domain.Models;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace LGSTrackingSystem.Services.Services
{
    public class UserService : Service<User>
    {
        public UserService(LGSTrackingDBContext context) : base(context)
        {

        }

        public async Task<User> GetUserByUsernameAndPasswordAsync(string username, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
        }
    }
}
