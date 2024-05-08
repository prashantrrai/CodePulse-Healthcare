using CodePulse.API.Domain.DTOs.Request;
using CodePulse.API.Domain.Models;
using CodePulse.API.Repositories.Interface;
using CodePulse.API.Repository.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository loginRepository;

        public LoginController(ILoginRepository loginRepository)
        {
            this.loginRepository = loginRepository;
        }



        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestDto request)
        {
            try
            {
                var response = await loginRepository.Login(request);

                return Ok(response);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
