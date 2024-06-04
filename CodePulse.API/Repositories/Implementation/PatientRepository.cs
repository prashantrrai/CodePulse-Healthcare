using CodePulse.API.Data;
using CodePulse.API.Domain.Models;
using CodePulse.API.Repository.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Repository.Implementation
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext dbcontext;

        public PatientRepository(ApplicationDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }




        public async Task<Patient> AddPatient(Patient patient)
        {
            try
            {
                await dbcontext.Patients.AddAsync(patient);
                await dbcontext.SaveChangesAsync();
                return patient;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<List<Patient>> GetAllPatient()
        {
            try
            {
                var patient = await dbcontext.Patients.ToListAsync();
                return patient;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Patient> GetPatientById(Guid id)
        {
            try
            {
                var patient = await dbcontext.Patients.FindAsync(id);
                if (patient is null)
                {
                    return null;
                }
                return patient;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Patient> UpdatePatient(Guid id, Patient patient)
        {
            try
            {
                var existingPatient = await dbcontext.Patients.FindAsync(id);
                if (existingPatient is null)
                {
                    throw new KeyNotFoundException($"Patient with ID {id} not found.");
                }

                existingPatient.Name = patient.Name;
                existingPatient.Age = patient.Age;
                existingPatient.Email = patient.Email;
                existingPatient.Phone = patient.Phone;
                existingPatient.Address = patient.Address;
                existingPatient.IsActive = true;
                await dbcontext.SaveChangesAsync();
                return existingPatient;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<Patient> DeletePatient(Guid id)
        {
            try
            {
                var patient = await dbcontext.Patients.FindAsync(id);
                if (patient is null)
                {
                    throw new KeyNotFoundException($"Patient with ID {id} not found.");
                }
                dbcontext.Patients.Remove(patient);
                await dbcontext.SaveChangesAsync();
                return patient;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
