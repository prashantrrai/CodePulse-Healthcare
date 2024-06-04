using CodePulse.API.Domain.Models;

namespace CodePulse.API.Repository.Interface
{
    public interface IPatientRepository
    {
        Task<Patient> AddPatient(Patient patient);
        Task<List<Patient>> GetAllPatient();  
        Task<Patient> GetPatientById(Guid id);  
        Task<Patient> UpdatePatient(Guid id, Patient patient);  
        Task<Patient> DeletePatient(Guid id);  
    } 
}
