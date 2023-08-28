using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using YourCarSlot.Application.Contracts.Infrastructure;
using YourCarSlot.Application.Logging;
using YourCarSlot.Domain.Common;

namespace YourCarSlot.Infrastructure.Email
{
    public class EmailSender : IEmailSender
    {
        private readonly MailSettings _settings;
        private readonly IAppLogger<EmailSender> _logger;

        public EmailSender(IOptions<MailSettings> settings, IAppLogger<EmailSender> logger)
        {
            _settings = settings.Value ?? throw new ArgumentNullException(nameof(settings));
            _logger = logger;
        }

        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_settings.Mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;
            var builder = new BodyBuilder();
            if (mailRequest.Attachments != null)
            {
                byte[] fileBytes;
                foreach (var file in mailRequest.Attachments)
                {
                    if (file.Length > 0)
                    {
                        using (var ms = new MemoryStream())
                        {
                            file.CopyTo(ms);
                            fileBytes = ms.ToArray();
                        }
                        builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
                    }
                }
            }
            builder.HtmlBody = mailRequest.Body;
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            smtp.Connect(_settings.Host, _settings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_settings.Mail, _settings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }
}
