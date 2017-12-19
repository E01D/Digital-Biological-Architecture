using E01D.Samples.Architecture.ObjectContext1.Models;

namespace E01D.Samples.Architecture.ObjectContext1.Api.Layers
{
    public class WebEntryLayer
    {
        public void RestCallEntryPoint()
        {
            
        }

        public void DoWebOp(OperationInputData input)
        {
            Transaction transaction = null;

            try
            {
                var ipAddress = X.Http.Requests.GetIpAddress();

                var logId = X.Logging.Log(ipAddress);

                var cookies = X.Http.Requests.Cookies.GetCookies();
                var headers = X.Http.Requests.Headers.GetHeaders();


                AuthenticationToken token;

                if ((token = X.Security.Authentication.Authenticate(headers)) == null)
                {
                    return;
                }

                X.Logging.Log(logId, token);

                transaction = X.Transactions.StartTransaction();

                X.Layers.Business.Operation1(logId, cookies, token, input);
            }
            catch (System.Exception e)
            {

            }
            finally
            {
                X.Transactions.FinalizeTransaction(transaction);
            }
        }
    }
}
