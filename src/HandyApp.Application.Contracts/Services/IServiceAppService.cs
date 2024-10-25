using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace HandyApp.Services
{
    public interface IServiceAppService :
          ICrudAppService< //Defines CRUD methods
              ServiceDto, //Used to show services
              Guid, //Primary key of the service entity
              PagedAndSortedResultRequestDto, //Used for paging/sorting
              CreateUpdateServiceDto> //Used to create/update a service
    {
    }
}
