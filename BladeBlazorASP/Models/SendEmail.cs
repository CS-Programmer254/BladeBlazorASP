using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;

namespace BladeBlazorASP.Models
{
    public class SendEmail
    {
        [ValidateNever]
        public string FromEmail{ get; set; }

        [DisplayName("To:")]
        public string ToEmail{ get; set; }

        [DisplayName("Subject:")]
        public string Subject{ get; set; }

        [DisplayName("Message:")]
        public string EmailMessageBody { get; set; }

        [DisplayName("Attach File:")]
        [ValidateNever]
        public string ? EmailAttachmentUrl { get; set; }
    }
}
