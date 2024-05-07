using CodePulse.API.Data;
using CodePulse.API.Domain.Models;
using CodePulse.API.Repositories.Interface;

namespace CodePulse.API.Repositories.Implementation
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ApplicationDbContext dbcontext;

        public LoginRepository(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public Task<Login> Login(Login login)
        {
            throw new NotImplementedException();
        }
    }
}
