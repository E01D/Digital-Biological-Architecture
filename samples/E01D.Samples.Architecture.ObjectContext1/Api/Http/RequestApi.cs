using E01D.Samples.Architecture.ObjectContext1.Api.Http.Requests;

namespace E01D.Samples.Architecture.ObjectContext1.Api.Http
{
    public class RequestApi
    {
        public CookieApi Cookies { get; set; } = new CookieApi();

        public HeaderApi Headers { get; set; } = new HeaderApi();

        public string GetIpAddress()
        {
            return "0.0.0.0";
        }
    }
}
