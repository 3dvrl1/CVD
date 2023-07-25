using ContactLoaderPlugin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneApp.Domain.DTO;

namespace ContactLoaderPlugin.Interfaces
{
    internal interface IGetContactsApi
    {
        IEnumerable<DataTransferObject> GetUsersFromApi();
    }
}
