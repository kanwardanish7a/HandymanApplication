using HandyApp.HandymanApplicationCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace HandyApp.Services
{
    public class ServiceDto : AuditedEntityDto<Guid>
    {
        public string ServiceName { get; set; }

        public int ServiceCost { get; set; }

        public ServiceType ServiceType { get; set; }
    }
}
