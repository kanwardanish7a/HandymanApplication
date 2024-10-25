using HandyApp.HandymanApplicationCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandyApp.Services
{
    public class CreateUpdateServiceDto
    {
        [Required]
        [StringLength(128)]
        public string ServiceName { get; set; } = string.Empty;

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Service cost must be greater than or equal to 0")]
        public int ServiceCost { get; set; }

        [Required]
        public ServiceType ServiceType { get; set; } 
    }
}
