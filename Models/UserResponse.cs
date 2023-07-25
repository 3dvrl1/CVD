using PhoneApp.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLoaderPlugin.Models
{
    internal class UserResponse : DataTransferObject
    {
        public List<User> Users { get; set; }
    }
}
