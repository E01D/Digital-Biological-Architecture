using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E01D.Samples.Architecture.ObjectContext1.Models;

namespace E01D.Samples.Architecture.ObjectContext1.Api
{
    public class LoggingApi
    {
        public LogId LogCall(string ipAddress, string authToken)
        {
            return CreateLogId();
        }

        public LogId CreateLogId()
        {
            return new LogId();
        }

        internal LogId Log(string ipAddress)
        {
            return CreateLogId();
        }

        /// <summary>
        /// Appends the authentication token to the corresponding log entry
        /// </summary>
        /// <param name="logId"></param>
        /// <param name="token"></param>
        public void Log(LogId logId, AuthenticationToken token)
        {
            
        }
    }

    
}
