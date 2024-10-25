using HandyApp.HandymanApplicationCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace HandyApp.Buyer
{
    public class BuyerProfile : AuditedAggregateRoot<Guid>, IUserProfile
    {
        public string Name { get ; set; }
        public UserType UserType { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Services.Service> PastRequestedServices { get; set; }
    }
}
