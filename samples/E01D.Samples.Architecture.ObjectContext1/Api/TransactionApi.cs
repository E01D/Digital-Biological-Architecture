using E01D.Samples.Architecture.ObjectContext1.Models;

namespace E01D.Samples.Architecture.ObjectContext1.Api
{
    public class TransactionApi
    {
        public Transaction StartTransaction()
        {
            return CreateTransaction();
        }

        public Transaction CreateTransaction()
        {
            return new Transaction();
        }

        public void FinalizeTransaction(Transaction transaction)
        {
            // commit or rollback
        }
    }
}
