using CodePulse.API.Data;
using CodePulse.API.Domain.Models;
using CodePulse.API.Repository.Interface;
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


        public async Task<PatientDetail> CreateAsync(PatientDetail patient)
        {
            await dbcontext.PatientDetails.AddAsync(patient);
            await dbcontext.SaveChangesAsync();

            return patient;
        }

        public async Task<List<PatientDetail>> GetAllAsync()
        {
            var result = await dbcontext.PatientDetails.ToListAsync();

            return result;
        }
    }
}
