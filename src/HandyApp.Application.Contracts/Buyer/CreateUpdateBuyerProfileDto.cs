using HandyApp.HandymanApplicationCommon;
using HandyApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandyApp.Buyer
{
    public class CreateUpdateBuyerProfileDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public UserType UserType { get; set; } = UserType.Buyer;

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public List<ServiceDto>? PastRequestedServices { get; set; }
    }
}
