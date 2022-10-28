using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02Library.Contexts.DevClasses
{
    public class ExceptionLog
    {
        public Guid Id { get; set; } = Guid.Empty;

        public string Class { get; set; } = string.Empty;

        public string Method { get; set; } = string.Empty;

        public string Data { get; set; } = string.Empty;

        public string HelpLink { get; set; } = string.Empty;

        public string HResult { get; set; } = string.Empty;

        public string InnerException { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public string Source { get; set; } = string.Empty;

        public string StackTrace { get; set; } = string.Empty;

        public string TargetSite { get; set; } = string.Empty;

        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
