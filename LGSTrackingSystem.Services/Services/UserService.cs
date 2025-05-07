using LGSTrackingSystem.Domain.Interfaces;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Repositories;
using LGSTrackingSystem.Repositories.Repositories;

namespace LGSTrackingSystem.Services.Services
{
    public class UserService
    {
        private readonly LGSTrackingDBContext _dbContext;
        private readonly IRepository<User> _userRepository;

        public UserService()
        {
            _dbContext = new LGSTrackingDBContext();
            _userRepository = new UserRepository(_dbContext);
        }

        public async Task<User?> CheckCredentialsAsync(string username, string password)
        {
            if (_userRepository is UserRepository repository)
                return await repository.GetUserByUsernameAndPasswordAsync(username, password);
            return null;
        }
    }
}
