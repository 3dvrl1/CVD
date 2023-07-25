using ContactLoaderPlugin.Interfaces;
using ContactLoaderPlugin.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PhoneApp.Domain.DTO;

namespace ContactLoaderPlugin.Action
{
    internal class UsersFromApi : IGetContactsApi
    {
        /*MapperConfiguration conf = new MapperConfiguration(cfg => cfg.CreateMap<User, EmployeesDTO>()
            .ForMember(dest=>dest.Name, opt=>opt.MapFrom(src=>src.Name))
            .ForMember(dest=>dest.Phone, opt=>opt.MapFrom(src=>src.Phone))
        );*/
        
        IEnumerable<DataTransferObject> IGetContactsApi.GetUsersFromApi()
        {
            string url = "https://dummyjson.com/users";
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;
            var data = JsonConvert.DeserializeObject<UserResponse>(response);
            return data.Users;

        }
    }
}
