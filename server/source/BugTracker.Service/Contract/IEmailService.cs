using BugTracker.Domain.Settings;
using System.Threading.Tasks;

namespace BugTracker.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
