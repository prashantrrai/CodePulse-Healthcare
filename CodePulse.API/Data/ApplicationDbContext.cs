using CodePulse.API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }


        public DbSet<PatientDetail> PatientDetails { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
