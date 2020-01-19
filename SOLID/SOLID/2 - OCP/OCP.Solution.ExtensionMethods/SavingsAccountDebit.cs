namespace SOLID.OCP.Solution.ExtensionMethods
{
    public static class SavingsAccountDebit
    {
        public static string DebitSavingsAccount(this AccountDebit accountDebit)
        {
            // Business logic for savings account debit.
            return accountDebit.FormatsTransaction();
        }
    }
}
