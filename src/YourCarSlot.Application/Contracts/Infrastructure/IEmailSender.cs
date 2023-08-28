using YourCarSlot.Domain.Common;

namespace YourCarSlot.Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
