using E01D.Samples.Architecture.ObjectContext1.Models;

namespace E01D.Samples.Architecture.ObjectContext1.Api.Layers
{
    public class DataLayer
    {
        public OperationOutputData Operation1(LogId logId,  OperationInputData input)
        {
            return DoOperation1(input);
        }

        private OperationOutputData DoOperation1(OperationInputData input)
        {
            return new OperationOutputData();
        }

        public void Operation2(LogId logId, OperationInputData input, OperationOutputData output)
        {
            DoOperation2(input, output);
        }

        private void DoOperation2(OperationInputData input, OperationOutputData output)
        {
            
        }
    }
}
