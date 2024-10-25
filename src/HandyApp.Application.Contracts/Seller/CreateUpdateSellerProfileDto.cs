using HandyApp.HandymanApplicationCommon;
using HandyApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandyApp.Seller
{
    public class CreateUpdateSellerProfileDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public UserType UserType { get; set; } = UserType.Seller;

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public List<ServiceDto>? PastOrders { get; set; }

        public List<ServiceDto>? CurrentOrders { get; set; }

        public List<ServiceDto>? MyGigs { get; set; }
    }
}
