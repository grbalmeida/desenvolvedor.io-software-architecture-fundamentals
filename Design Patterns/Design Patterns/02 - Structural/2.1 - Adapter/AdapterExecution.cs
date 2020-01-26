namespace DesignPatterns.Adapter
{
    public class AdapterExecution
    {
        public static void Execute()
        {
            var standardLogPayment = new TransactionService(new Logger());
            standardLogPayment.PerformTransaction();

            var customLogPayment = new TransactionService(new LogAdapter(new LogNetMasterService()));
            customLogPayment.PerformTransaction();
        }
    }
}