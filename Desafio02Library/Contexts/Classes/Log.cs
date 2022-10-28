using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02Library.Contexts.DevClasses
{
    public class Log
    {
        public Guid Id { get; set; } = Guid.Empty;

        public string Operacao { get; set; }

        public string Valor { get; set; }

        public string Classe { get; set; }

        public DateTime DataHora { get; set; } = DateTime.Now;
    }
}
