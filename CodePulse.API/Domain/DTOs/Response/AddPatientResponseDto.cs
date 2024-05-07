namespace CodePulse.API.Domain.DTOs.Response
{
    public class AddPatientResponseDto
    {
        public Guid Id { get; set; }
        public int Token { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
