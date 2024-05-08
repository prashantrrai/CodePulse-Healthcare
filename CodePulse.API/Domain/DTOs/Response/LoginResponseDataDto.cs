namespace CodePulse.API.Domain.DTOs.Response
{
    public class LoginResponseDataDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; } = 5;
        public bool IsActive { get; set; } = false;
        public int Token { get; set; }
    }
}
