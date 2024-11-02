using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HandyApp.Orders
{
    public interface IOrderAppService :
        ICrudAppService< //Defines standard CRUD methods
            OrderDto, //Used to show orders
            Guid, //Primary key of the order entity
            PagedAndSortedResultRequestDto, //Used for paging and sorting
            CreateUpdateOrderDto //Used to create/update an order
        >
    {
    }
}
