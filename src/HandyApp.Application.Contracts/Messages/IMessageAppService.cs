using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HandyApp.Messages
{
    public interface IMessageAppService :
        ICrudAppService< // Defines CRUD methods
            MessageDto, // Used to show messages
            Guid, // Primary key of the message entity
            PagedAndSortedResultRequestDto, // Used for paging/sorting
            CreateUpdateMessageDto> // Used to create/update a message
    {
    }
}
