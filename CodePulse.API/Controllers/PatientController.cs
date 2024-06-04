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
        public async Task<IActionResult> AddPatient(PatientRequestDto request)
        {
            try
            {
                var patient = new Patient
                {
                    Name = request.Name,
                    Age = request.Age,
                    Email = request.Email,
                    Phone = request.Phone,
                    Address = request.Address,
                    IsActive = request.IsActive
                };

                var response = await patientRepository.AddPatient(patient);
                return Ok(response);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            try
            {
                var result = await patientRepository.GetAllPatient();
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetPatientById(Guid id)
        {
            try
            {
                var result = await patientRepository.GetPatientById(id);
                if (result == null)
                {
                    return NotFound(new { Message = $"Patient with ID {id} not found." });
                }
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdatePatient(Guid id, PatientRequestDto request)
        {
            try
            {
                var patient = new Patient
                {
                    Name = request.Name,
                    Age = request.Age,
                    Email = request.Email,
                    Phone = request.Phone,
                    Address = request.Address,
                    IsActive = request.IsActive
                };
                var response = await patientRepository.UpdatePatient(id, patient);
                return Ok(response);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpDelete("{id:Guid}")]
        //[Route("{id: Guid}")]
        public async Task<IActionResult> DeletePatient(Guid id)
        {
            try
            {
                var response = await patientRepository.DeletePatient(id);
                return Ok(response);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
