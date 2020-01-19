namespace SOLID.OCP.Solution.ExtensionMethods
{
    public static class InvestmentAccountDebit
    {
        public static string DebitInvestmentAccount(this AccountDebit accountDebit)
        {
            // Business logic for investment account debit.
            return accountDebit.FormatsTransaction();
        }
    }
}
