namespace DesignPatterns.Adapter
{
    // Client
    public class TransactionService
    {
        private readonly ILogger _logger;

        public TransactionService(ILogger logger)
        {
            _logger = logger;
        }

        public void PerformTransaction()
        {
            // Transaction
            _logger.Log("Transaction completed");
        }
    }
}