using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandyApp.HandymanApplicationCommon
{
    public interface IUserProfile
    {
        public string Name { get; set; }

        public UserType UserType { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
