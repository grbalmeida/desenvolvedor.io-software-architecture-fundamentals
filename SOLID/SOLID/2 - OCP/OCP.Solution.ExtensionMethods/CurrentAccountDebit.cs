namespace SOLID.OCP.Solution.ExtensionMethods
{
    public static class CurrentAccountDebit
    {
        public static string DebitCurrentAccount(this AccountDebit accountDebit)
        {
            // Business logic for current account debit.
            return accountDebit.FormatsTransaction();
        }
    }
}
