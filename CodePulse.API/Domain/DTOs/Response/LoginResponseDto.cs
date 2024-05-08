namespace CodePulse.API.Domain.DTOs.Response
{
    public class LoginResponseDto
    {
        public bool Success { get; set; } 
        public string Message { get; set; }
        public LoginResponseDataDto Data { get; set; }
    }
}
