using Desafio02Library.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02Library.Controllers
{
    public class DevController
    {
        public static List<Dev>? GetDevs()
        {
            var devs = DevClient.GetAllDevelopersAsync();
            LogController.LogOperation("GetDevs", "DevController");

            return devs.Result;
        }

        public static Dev? GetDevById(int id)
        {
            var devs = DevClient.GetDevelopersByIdAsync(id);
            LogController.LogOperation("GetDevById", "DevController", devs.Result);

            return devs.Result;
        }

        public static Dev? AddDev(Dev dev)
        {
            var createdDev = DevClient.AddDev(dev);
            LogController.LogOperation("AddDev", "DevController", createdDev.Result);

            return createdDev.Result;
        }

        public static Dev? UpdateDev(Dev dev)
        {
            var updatedDev = DevClient.UpdateDev(dev);
            LogController.LogOperation("UpdateDev", "DevController", updatedDev.Result);

            return updatedDev.Result;
        }        
    }
}
