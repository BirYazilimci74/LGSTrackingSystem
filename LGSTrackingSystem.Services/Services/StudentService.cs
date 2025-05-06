using LGSTrackingSystem.Domain.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace LGSTrackingSystem.Services.Services
{
    public class StudentService : Service<Student>
    {
        public StudentService(LGSTrackingDBContext context) : base(context)
        {

        }

        public async Task<Student> GetStudentByUserIdAsync(int userId)
        {
            return await _context.Students.FirstOrDefaultAsync(s => s.UserId == userId);
        }
    }
}
