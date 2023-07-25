using PhoneApp.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactLoaderPlugin.Models
{
    internal class User : DataTransferObject
    {
        [JsonProperty("firstName")]
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
