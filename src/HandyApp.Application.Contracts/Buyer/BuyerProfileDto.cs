using HandyApp.HandymanApplicationCommon;
using HandyApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace HandyApp.Buyer
{
    public class BuyerProfileDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public UserType UserType { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<ServiceDto> PastRequestedServices { get; set; }
    }
}
