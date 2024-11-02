using System;
using System.ComponentModel.DataAnnotations;

namespace HandyApp.Messages
{
    public class CreateUpdateMessageDto
    {
        [Required]
        public string Sender { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime ReceivedDate { get; set; } = DateTime.Now;
    }
}
