using System;
using System.Collections.Generic;
using E01D.Samples.Architecture.ObjectContext1.Models;

namespace E01D.Samples.Architecture.ObjectContext1.Api.Http.Requests
{
    public class HeaderApi
    {
        public List<Header> GetHeaders()
        {
            return CreateHeaderList();
        }

        private List<Header> CreateHeaderList()
        {
            return new List<Header>();
        }
    }
}
