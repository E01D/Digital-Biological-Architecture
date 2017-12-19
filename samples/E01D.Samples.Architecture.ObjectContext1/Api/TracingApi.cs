using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using E01D.Samples.Architecture.ObjectContext1.Models;

namespace E01D.Samples.Architecture.ObjectContext1.Api
{
    public class TracingApi
    {
        public void Trace(LogId logId, [CallerMemberName] string memberName = null)
        {
            
        }
    }
}
