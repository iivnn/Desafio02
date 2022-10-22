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

            return devs.Result;
        }

        public static Dev? GetDevById(int id)
        {
            var devs = DevClient.GetDevelopersByIdAsync(id);

            return devs.Result;
        }
    }
}
