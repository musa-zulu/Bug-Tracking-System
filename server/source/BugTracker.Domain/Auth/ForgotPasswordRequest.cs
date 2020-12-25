using System.ComponentModel.DataAnnotations;

namespace BugTracker.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
