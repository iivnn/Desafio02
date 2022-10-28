using Desafio02Library.Contexts.DevClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02Library.Controllers
{
    public class LogController
    {
        public static void Logexception(Exception ex, string class1, string method)
        {
            if(ex != null)
            {
                var exceptionlog = new ExceptionLog()
                {
                    Data = ex.Data != null ? ex.Data.ToString() : "null",
                    HelpLink = ex.HelpLink != null ? ex.HelpLink.ToString() : "null",
                    HResult = ex.HResult != null ? ex.HResult.ToString() : "null",
                    InnerException = ex.InnerException != null ? ex.InnerException.ToString() : "null",
                    Message = ex.Message != null ? ex.Message.ToString() : "null",
                    Source = ex.Source != null ? ex.Source.ToString() : "null",
                    StackTrace = ex.StackTrace != null ? ex.StackTrace.ToString() : "null",
                    TargetSite = ex.TargetSite != null ? ex.TargetSite.ToString() : "null",
                    Class = class1,
                    Method = method,
                };

                var devContext = new DevContext();
                devContext.ExceptionLogs.Add(exceptionlog);
                devContext.SaveChanges();
                devContext.Dispose();
            }
        }

        public static void LogOperation(string operacao, string classe, object obj = null)
        {
            var log = new Log()
            {
                Operacao = operacao,
                Valor = obj == null ? string.Empty : Newtonsoft.Json.JsonConvert.SerializeObject(obj),
                Classe = classe,
            };

            var devContext = new DevContext();
            devContext.Logs.Add(log);
            devContext.SaveChanges();
            devContext.Dispose();
        }

        public static List<ExceptionLog> GetAllExceptionLogs()
        {
            var devContext = new DevContext();
            var exceptionLogs = devContext.ExceptionLogs.ToList();
            devContext.Dispose();

            return exceptionLogs;
        }

        public static List<Log> GetAllLogs()
        {
            var devContext = new DevContext();
            var logs = devContext.Logs.ToList();
            devContext.Dispose();

            return logs;
        }
    }
}
