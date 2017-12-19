using E01D.Samples.Architecture.ObjectContext1.Api.Security;

namespace E01D.Samples.Architecture.ObjectContext1.Api
{
    public class SecurityApi
    {
        public AuthenticationApi Authentication { get; set; } = new AuthenticationApi();
        public AuthorizationApi Authorization { get; set; } = new AuthorizationApi();
    }
}
