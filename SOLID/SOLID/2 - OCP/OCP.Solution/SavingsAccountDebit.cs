namespace SOLID.OCP.Solution
{
    public class SavingsAccountDebit : AccountDebit
    {
        public override string Debit(decimal value, string account)
        {
            // Validates Account Anniversary
            // Debit Savings Account
            return FormatsTransaction();
        }
    }
}
