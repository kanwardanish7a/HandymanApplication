using System;
using System.ComponentModel.DataAnnotations;
using HandyApp.HandymanApplicationCommon;
using HandyApp.Services;

namespace HandyApp.Orders
{
    public class CreateUpdateOrderDto
    {
        [Required]
        public Guid BuyerId { get; set; } // Foreign key referencing Buyer

        [Required]
        public Guid SellerId { get; set; } // Foreign key referencing Seller

        [Required]
        [StringLength(256)]
        public string ServiceName { get; set; } = string.Empty; // Name of the service being ordered

        [Required]
        public int ServiceCost { get; set; } // Cost of the service

        [Required]
        public ServiceType ServiceType { get; set; } // Type of service, based on the ServiceType enum

        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; } = DateTime.Now; // Date when the order was placed

        public DateTime? CompletionDate { get; set; } // Nullable date when the order was completed

        [Required]
        public OrderStatus Status { get; set; } = OrderStatus.Pending; // Status of the order, based on the OrderStatus enum
    }
}
