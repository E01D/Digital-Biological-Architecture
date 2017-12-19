using E01D.Samples.Architecture.ObjectContext1.Api;

namespace E01D.Samples.Architecture.ObjectContext1
{
    public static class X
    {
        public static SampleApi Api { get; set; } = new SampleApi();

        public static LayerApi Layers => Api.Layers;

        public static LoggingApi Logging => Api.Logging;

        public static SecurityApi Security => Api.Security;

        public static TracingApi Tracing => Api.Tracing;

        public static TransactionApi Transactions => Api.Transactions;

        public static HttpApi Http => Api.Http;
    }
}
