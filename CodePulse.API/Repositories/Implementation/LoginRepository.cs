using CodePulse.API.Data;
using CodePulse.API.Domain.DTOs.Request;
using CodePulse.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Repositories.Implementation
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ApplicationDbContext dbcontext;

        public LoginRepository(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public async Task<bool> Login(LoginRequestDto credentials)
        {
            try
            {
                var data = await dbcontext.PatientDetails.FirstOrDefaultAsync(x => x.Email == credentials.Email);


                if (data == null)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
