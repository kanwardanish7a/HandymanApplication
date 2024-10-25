using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HandyApp.Buyer
{
    public interface IBuyerProfileAppService :
       ICrudAppService< //Defines CRUD methods
           BuyerProfileDto, //Used to show buyer profiles
           Guid, //Primary key of the buyer profile entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateBuyerProfileDto> //Used to create/update a buyer profile
    {
    }
}
