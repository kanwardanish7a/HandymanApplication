using HandyApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace HandyApp.Service
{
    public class ServiceAppService :
        CrudAppService<
            Services.Service, // The Service entity
            ServiceDto, // Used to show services
            Guid, // Primary key of the service entity
            PagedAndSortedResultRequestDto, // Used for paging/sorting
            CreateUpdateServiceDto>, // Used to create/update a service
        IServiceAppService // Implement the IServiceAppService
    {
        public ServiceAppService(IRepository<Services.Service, Guid> repository)
            : base(repository)
        {
        }
    }
}
