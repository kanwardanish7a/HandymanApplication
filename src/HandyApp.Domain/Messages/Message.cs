using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace HandyApp.Messages
{
    public class Message : AuditedAggregateRoot<Guid>
    {
        public string Sender { get; set; } // The user who sent the message
        public string Recipient { get; set; } // The user who receives the message
        public string Content { get; set; } // The content of the message
        public DateTime SentDate { get; set; } // The date and time when the message was sent

        // Optionally, you can add a constructor to initialize the message
        public Message()
        {
            SentDate = DateTime.Now; // Set the sent date to now by default
        }
    }
}
