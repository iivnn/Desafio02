using Desafio02Library.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02Library.Controllers
{
    public class SquadController
    {
        public static List<Squad> GetAllSquads()
        {
            var devContext = new DevContext();
            var squads = devContext.Squads.ToList();
            devContext.Dispose();
            return squads;
        }

        public static void RemoveSquad(int id)
        {
            var devContext = new DevContext();
            var squad = devContext.Squads.Find(id);
            devContext.Squads.Remove(squad);
            devContext.SaveChanges();
            devContext.Dispose();
        }

        public static void AddSquad(string nome)
        {
            var devContext = new DevContext();
            var squad = new Squad() { Nome = nome };
            devContext.Squads.Add(squad);
            devContext.SaveChanges();
            devContext.Dispose();
        }
    }
}
