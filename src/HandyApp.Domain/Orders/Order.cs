using HandyApp.HandymanApplicationCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace HandyApp.Orders
{
    public class Order : AuditedAggregateRoot<Guid>
    {
        public Guid BuyerId { get; set; } // Foreign key to BuyerProfile
        public string ServiceName { get; set; } // Name of the service
        public int ServiceCost { get; set; } // Cost of the service
        public ServiceType ServiceType { get; set; } // Type of service
        public DateTime OrderDate { get; set; } // Date when the service was ordered
        public DateTime? CompletionDate { get; set; } // Date when the service was completed
        public OrderStatus Status { get; set; } // Current status of the order
    }

    public enum OrderStatus
    {
        Pending,
        InProgress,
        Completed,
        Cancelled
    }
}
