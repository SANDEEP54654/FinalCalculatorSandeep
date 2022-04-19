using Microsoft.EntityFrameworkCore;

namespace FinalCalculatorSandeep.Models
{
    public class ApplicationUser : DbContext
    {
        public ApplicationUser(DbContextOptions<ApplicationUser> options) : base(options)
        {

        }
        public DbSet<User> UserRegistration { get; set; }
        public DbSet<CalcHistory> CalculationHistory { get; set; }
    }
}
