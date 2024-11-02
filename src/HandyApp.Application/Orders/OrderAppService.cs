using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HandyApp.Orders
{
    public class OrderAppService :
      CrudAppService<
          Order, // The Order entity
          OrderDto, // Used to show orders
          Guid, // Primary key of the order entity
          PagedAndSortedResultRequestDto, // Used for paging/sorting
          CreateUpdateOrderDto>, // Used to create/update an order
      IOrderAppService // Implement the IOrderAppService
    {
        public OrderAppService(IRepository<Order, Guid> repository)
            : base(repository)
        {
        }
    }
}
