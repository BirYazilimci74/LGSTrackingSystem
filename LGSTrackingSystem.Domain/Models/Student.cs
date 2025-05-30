﻿using System.ComponentModel.DataAnnotations;

namespace LGSTrackingSystem.Domain.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string SchoolName { get; set; }
        private string? _class;

        public string Class
        {
            get => $"8-{_class}";
            set
            {
                if (value.StartsWith("8-"))
                    _class = value.Substring(2);
                else
                    _class = value;
            }
        }

        public required int UserId { get; set; }
        public User User { get; set; }
        public List<Exam> Exams { get; set; } = new List<Exam>();
    }
}
