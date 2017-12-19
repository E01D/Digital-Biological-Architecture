namespace E01D.Samples.Architecture.ObjectContext1.Api
{
    public class SampleApi
    {
        public HttpApi Http { get; set; } = new HttpApi();

        public LayerApi Layers { get; set; } = new LayerApi();

        public LoggingApi Logging { get; set; } = new LoggingApi();

        

        public SecurityApi Security { get; set; } = new SecurityApi();

        public TracingApi Tracing { get; set; } = new TracingApi();

        public TransactionApi Transactions { get; set; } = new TransactionApi();
        
    }
}
