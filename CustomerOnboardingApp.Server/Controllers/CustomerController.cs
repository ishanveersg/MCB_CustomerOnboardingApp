using Microsoft.AspNetCore.Mvc;
using CustomerOnboardingApp.Server.Models;
using CustomerOnboardingApp.Server.Services;

namespace CustomerOnboardingApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateApplication(CustomerApplication application)
        {
            var result = await _customerService.CreateApplicationAsync(application);
            return CreatedAtAction(nameof(CreateApplication), new { id = result.Id }, result);
        }

    }
}