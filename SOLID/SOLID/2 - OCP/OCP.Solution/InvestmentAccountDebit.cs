namespace SOLID.OCP.Solution
{
    public class InvestmentAccountDebit : AccountDebit
    {
        public override string Debit(decimal value, string account)
        {
            // Debit Investment Account
            // Exempt fees
            return FormatsTransaction();
        }
    }
}
