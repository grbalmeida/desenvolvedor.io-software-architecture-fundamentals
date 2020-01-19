namespace SOLID.OCP.Solution
{
    public class CurrentAccountDebit : AccountDebit
    {
        public override string Debit(decimal value, string account)
        {
            // Debit Current Account
            return FormatsTransaction();
        }
    }
}
