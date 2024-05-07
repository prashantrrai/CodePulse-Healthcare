namespace CodePulse.API.Domain.Models
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Result { get; set; } = false;
        public string? Token { get; set; }
        public DateTime LastLogin { get; set; } = DateTime.Now;
    }
}
