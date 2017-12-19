using System.Collections.Generic;
using E01D.Samples.Architecture.ObjectContext1.Models;

namespace E01D.Samples.Architecture.ObjectContext1.Api.Layers
{
    public class BusinessLayer
    {
        public OperationOutputData Operation1(LogId logId, List<Cookie> neededCookies, AuthenticationToken authToken, OperationInputData input)
        {
            X.Tracing.Trace(logId);

            X.Security.Authorization.Authorize(authToken);

            OperationOutputData output = DoOperation1(logId, neededCookies, input);

            return Operation2(logId, neededCookies, authToken, input, output);
        }

        public OperationOutputData Operation2(LogId logId, List<Cookie> neededCookies, AuthenticationToken authToken, OperationInputData input, OperationOutputData output)
        {
            X.Tracing.Trace(logId);

            X.Security.Authorization.Authorize(authToken);

            DoOperation2(logId, neededCookies, input, output);

            return output;
        }

        private OperationOutputData DoOperation1(LogId logId, List<Cookie> neededCookies, OperationInputData input)
        {
            // do something

            return X.Layers.Data.Operation1(logId, input);
        }

        

        private void DoOperation2(LogId logId, List<Cookie> neededCookies, OperationInputData input, OperationOutputData output)
        {
            // do something else

            X.Layers.Data.Operation2(logId, input, output);
        }
    }
}
