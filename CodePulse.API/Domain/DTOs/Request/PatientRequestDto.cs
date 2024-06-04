﻿namespace CodePulse.API.Domain.DTOs.Request
{
    public class PatientRequestDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    }
}
