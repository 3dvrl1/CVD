using ContactLoaderPlugin.Interfaces;
using ContactLoaderPlugin.Models;
using PhoneApp.Domain.Attributes;
using PhoneApp.Domain.DTO;
using PhoneApp.Domain.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;


namespace ContactLoaderPlugin.Action
{
    [Author(Name = "Vasilii Tagintsev")]
    internal class Plugin : IPluggable
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public readonly IGetContactsApi _getContactsApi;
        public Plugin()
        {
            _getContactsApi = new UsersFromApi();
        }
        public IEnumerable<DataTransferObject> Run(IEnumerable<DataTransferObject> args)
        {
            var sourceList = _getContactsApi.GetUsersFromApi();
            IEnumerable<EmployeesDTO> destList = sourceList.Adapt<IEnumerable<EmployeesDTO>>();
            var dataTransferObjects = destList.ToList();
            logger.Info($"Loaded {dataTransferObjects.Count()} employees");
            return dataTransferObjects;
        }
    }
}
