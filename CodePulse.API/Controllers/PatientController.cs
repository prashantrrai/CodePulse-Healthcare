using CodePulse.API.Data;
using CodePulse.API.Domain.DTOs.Request;
using CodePulse.API.Domain.Models;
using CodePulse.API.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository patientRepository;

        public PatientController(IPatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }


        [HttpPost]
        public async Task<IActionResult> AddPatient(AddPatientRequestDto request)
        {
            try
            {
                //--------Map DTO to Domain Model-------------//
                var patient = new PatientDetail
                {
                    Name = request.Name,
                    Age = request.Age,
                    Email = request.Email,
                    Password = request.Password,
                    Phone = request.Phone,
                    Address = request.Address
                };

                await patientRepository.CreateAsync(patient);


                //--------Map Domain Model to DTO-------------//
                var response = new PatientDetail
                {
                    Id = patient.Id,
                    Name = patient.Name,
                    Age = patient.Age,
                    Email = patient.Email,
                    Password = patient.Password,
                    Phone = patient.Phone,
                    Address = patient.Address
                };

                return Ok(response);

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPatients()
        {
            try
            {
                var result = await patientRepository.GetAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
