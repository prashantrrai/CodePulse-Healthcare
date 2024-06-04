using CodePulse.API.Data;
using CodePulse.API.Domain.DTOs.Request;
using CodePulse.API.Domain.DTOs.Response;
using CodePulse.API.Domain.Models;
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

        public async Task<LoginResponseDto> Login(LoginRequestDto credentials)
        {
            try
            {
                //var patient = await dbcontext.Patients.FirstOrDefaultAsync(x => x.Email == credentials.Email && x.Password == credentials.Password);
                var patient = await dbcontext.Patients.FirstOrDefaultAsync(x => x.Email == credentials.Email);

                if (patient == null)
                {
                    return new LoginResponseDto
                    {
                        Success = false,
                        Message = "Invalid email or password",
                        Data = null
                    };
                }

                var loginResponse = MapPatientToLoginResponse(patient);
                return new LoginResponseDto
                {
                    Success = true,
                    Message = "Login successful",
                    Data = loginResponse
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

        private LoginResponseDataDto MapPatientToLoginResponse(Patient patient)
        {
            return new LoginResponseDataDto
            {
                Name = patient.Name,
                Email = patient.Email,
                //RoleId = patient.RoleId,
                IsActive = patient.IsActive,
                //Token = patient.Token,
            };
        }
    }
}
