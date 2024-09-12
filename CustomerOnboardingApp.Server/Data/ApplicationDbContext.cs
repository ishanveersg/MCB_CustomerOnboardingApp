using Microsoft.EntityFrameworkCore;
using CustomerOnboardingApp.Server.Models;

namespace CustomerOnboardingApp.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerApplication> CustomerApplications { get; set; }
    }
}