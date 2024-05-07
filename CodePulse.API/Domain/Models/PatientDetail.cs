﻿namespace CodePulse.API.Domain.Models
{
    public class PatientDetail
    {
        public Guid Id { get; set; }
        public int Token { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int RoleId { get; set; } = 5;
        public bool IsActive { get; set; } = false;
        public DateTime LastLogin { get; set; } = DateTime.Now;
    }
}
