using CodePulse.API.Domain.DTOs.Request;
using CodePulse.API.Domain.Models;

namespace CodePulse.API.Repositories.Interface
{
    public interface ILoginRepository
    {
        Task<bool> Login(LoginRequestDto credentials);
    }
}
