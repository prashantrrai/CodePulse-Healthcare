using CodePulse.API.Domain.DTOs.Request;
using CodePulse.API.Domain.DTOs.Response;

namespace CodePulse.API.Repositories.Interface
{
    public interface ILoginRepository
    {
        Task<LoginResponseDto> Login(LoginRequestDto credentials);
    }
}
