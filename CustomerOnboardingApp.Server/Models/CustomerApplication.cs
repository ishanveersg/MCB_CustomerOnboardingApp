using System.ComponentModel.DataAnnotations;

namespace CustomerOnboardingApp.Server.Models
{
    public class CustomerApplication
    {
        public int Id { get; set; }

        [Required]
        public required string MainPurpose { get; set; }

        [Required]
        public required string CompanyName { get; set; }

        [Required]
        public required string EntityType { get; set; }

        [Required]
        public required string BusinessActivity { get; set; }

        public required string BankingLicense { get; set; }

        [Required]
        public required string CountryOfIncorporation { get; set; }

        [Required]
        public required string RegistrationNumber { get; set; }

        [Required]
        public required DateTime DateOfIncorporation { get; set; }

        [Required]
        public required string DirectorShareholderName { get; set; }

        [Required]
        public required string DirectorPassportNumber { get; set; }

        [Required]
        public required string DesignatedApplicantName { get; set; }

        [Required]
        [EmailAddress]
        public required string EmailAddress { get; set; }

        public required string DocumentPath { get; set; }
    }
}
