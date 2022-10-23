using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02Library.Contexts.DevClasses
{
    public class Log
    {
        public Guid id { get; set; } = Guid.Empty;

        public string Operacao { get; set; }
    }
}
