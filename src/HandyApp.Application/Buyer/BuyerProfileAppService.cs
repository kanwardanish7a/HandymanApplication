using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HandyApp.Buyer
{
    public class BuyerProfileAppService :
      CrudAppService<
          BuyerProfile, // The BuyerProfile entity
          BuyerProfileDto, // Used to show buyer profiles
          Guid, // Primary key of the buyer profile entity
          PagedAndSortedResultRequestDto, // Used for paging/sorting
          CreateUpdateBuyerProfileDto>, // Used to create/update a buyer profile
      IBuyerProfileAppService // Implement the IBuyerProfileAppService
    {
        public BuyerProfileAppService(IRepository<BuyerProfile, Guid> repository)
            : base(repository)
        {
        }
    }
}
