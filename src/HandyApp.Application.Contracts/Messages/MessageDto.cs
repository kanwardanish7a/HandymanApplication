using System;
using Volo.Abp.Application.Dtos;

namespace HandyApp.Messages
{
    public class MessageDto : AuditedEntityDto<Guid>
    {
        public string Sender { get; set; }
        public string Content { get; set; }
        public DateTime ReceivedDate { get; set; }
    }
}
