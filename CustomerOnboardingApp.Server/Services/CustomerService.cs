using CustomerOnboardingApp.Server.Data;
using CustomerOnboardingApp.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerOnboardingApp.Server.Services
{
    public class CustomerService
    {
        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CustomerApplication> CreateApplicationAsync(CustomerApplication application)
        {
            _context.CustomerApplications.Add(application);
            await _context.SaveChangesAsync();
            return application;
        }
    }
}