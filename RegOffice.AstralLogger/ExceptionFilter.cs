using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.AstralLogger
{
    public static class ExceptionFilter
    {
        public static string GetMessage(Exception ex)
        {
            var message = ex.Message;

            if (ex.InnerException != null)
            {
                message = string.Format("{0} {1}", message, ex.InnerException.Message);
            }

            if (ex.StackTrace != null)
                message = string.Format("{0} {1}", message, ex.StackTrace);

            return message;
        }
    }
}
