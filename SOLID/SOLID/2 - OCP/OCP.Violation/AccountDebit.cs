namespace SOLID.OCP.Violation
{
    public class AccountDebit
    {
        public void Debit(decimal value, string account, AccountType accountType)
        {
            if (accountType == AccountType.Current)
            {
                // Debit Current Account
            }

            if (accountType == AccountType.Savings)
            {
                // Validates Account Anniversary
                // Debit Savings Account
            }
        }
    }
}
