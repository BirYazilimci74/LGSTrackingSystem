using LGSTrackingSystem.Domain.Interfaces;
using LGSTrackingSystem.Domain.Models;
using LGSTrackingSystem.Repositories;
using LGSTrackingSystem.Repositories.Repositories;

namespace LGSTrackingSystem.Services.Services
{
    public class AdminService
    {
        private readonly LGSTrackingDBContext _context;
        private readonly IRepository<Admin> _adminRepository;

        public AdminService()
        {
            _context = new LGSTrackingDBContext();
            _adminRepository = new AdminRepository(_context);
        }

        public async Task<Admin?> GetAdminByUserIdAsync(int userId)
        {
            if (_adminRepository is AdminRepository adminRepository)
                return await adminRepository.GetAdminByUserIdAsync(userId);
            throw new InvalidOperationException("Admin repository is not available.");
        }
    }
}
