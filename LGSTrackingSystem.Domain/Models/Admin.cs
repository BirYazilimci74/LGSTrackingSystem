using System.ComponentModel.DataAnnotations;

namespace LGSTrackingSystem.Domain.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
