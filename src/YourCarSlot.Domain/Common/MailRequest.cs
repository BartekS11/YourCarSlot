using Microsoft.AspNetCore.Http;

namespace YourCarSlot.Domain.Common
{
    public class MailRequest
    {
        public string ToEmail { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public MailRequest() { }
        public List<IFormFile> Attachments { get; set; }
    }
}
