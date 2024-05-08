using CodePulse.API.Domain.Models;

namespace CodePulse.API.Repository.Interface
{
    public interface IPatientRepository
    {
        Task<PatientDetail> CreateAsync(PatientDetail patient);
        Task<List<PatientDetail>> GetAllAsync();  
    } 
}
