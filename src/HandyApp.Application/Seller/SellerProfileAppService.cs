using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HandyApp.Seller
{
    public class SellerProfileAppService :
        CrudAppService<
            SellerProfile, // The SellerProfile entity
            SellerProfileDto, // Used to show seller profiles
            Guid, // Primary key of the seller profile entity
            PagedAndSortedResultRequestDto, // Used for paging/sorting
            CreateUpdateSellerProfileDto>, // Used to create/update a seller profile
        ISellerProfileAppService // Implement the ISellerProfileAppService
    {
        public SellerProfileAppService(IRepository<SellerProfile, Guid> repository)
            : base(repository)
        {
        }
    }
}
