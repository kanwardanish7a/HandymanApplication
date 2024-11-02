using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HandyApp.Messages
{
    public class MessageAppService :
        CrudAppService< // The message entity
            Message, // The Message entity
            MessageDto, // Used to show messages
            Guid, // Primary key of the message entity
            PagedAndSortedResultRequestDto, // Used for paging/sorting
            CreateUpdateMessageDto>, // Used to create/update a message
        IMessageAppService // Implement the IMessageAppService
    {
        public MessageAppService(IRepository<Message, Guid> repository)
            : base(repository)
        {
        }
    }
}
