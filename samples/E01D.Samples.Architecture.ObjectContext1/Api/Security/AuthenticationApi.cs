using E01D.Samples.Architecture.ObjectContext1.Models;
using System.Collections.Generic;

namespace E01D.Samples.Architecture.ObjectContext1.Api.Security
{
    public class AuthenticationApi
    {
        public AuthenticationToken Authenticate(List<Header> headers)
        {
            return new AuthenticationToken();
        }
    }
}
