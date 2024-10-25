using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HandyApp.Seller
{
    public interface ISellerProfileAppService :
        ICrudAppService< //Defines CRUD methods
            SellerProfileDto, //Used to show seller profiles
            Guid, //Primary key of the seller profile entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSellerProfileDto> //Used to create/update a seller profile
    {
    }
}
