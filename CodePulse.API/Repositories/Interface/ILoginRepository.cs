using CodePulse.API.Domain.Models;

namespace CodePulse.API.Repositories.Interface
{
    public interface ILoginRepository
    {
        Task<Login> Login(Login login);
    }
}
