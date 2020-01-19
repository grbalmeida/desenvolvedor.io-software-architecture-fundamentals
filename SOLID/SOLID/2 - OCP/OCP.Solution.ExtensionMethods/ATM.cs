using System;

namespace SOLID.OCP.Solution.ExtensionMethods
{
    public class ATM
    {
        public static void Operations()
        {
            OperationsMenu();

            var option = Console.ReadKey();
            var transaction = string.Empty;

            var accountDebit = DebitData();

            switch (option.KeyChar)
            {
                case '1':
                    Console.WriteLine("Performing a Current Account operation");
                    transaction = accountDebit.DebitCurrentAccount();
                    break;
                case '2':
                    Console.WriteLine("Performing a Savings Account operation");
                    transaction = accountDebit.DebitSavingsAccount();
                    break;
                case '3':
                    Console.WriteLine("Performing an Investment Account operation");
                    transaction = accountDebit.DebitInvestmentAccount();
                    break;
            }

            ReturnTransaction(transaction);
        }

        private static void OperationsMenu()
        {
            Console.Clear();
            Console.WriteLine("ATM SOLID");
            Console.WriteLine("Choose your option:");
            Console.WriteLine();
            Console.WriteLine("1 - Withdraw Current Account");
            Console.WriteLine("2 - Withdraw Savings Account");
            Console.WriteLine("3 - Withdraw Investment Account");
        }

        private static AccountDebit DebitData()
        {
            Console.WriteLine();
            Console.WriteLine("..............................");
            Console.WriteLine();
            Console.WriteLine("Enter account");
            var account = Console.ReadLine();
            Console.WriteLine("Enter value");
            var value = Convert.ToDecimal(Console.ReadLine());

            var accountDebit = new AccountDebit()
            {
                AccountNumber = account,
                Value = value
            };

            return accountDebit;
        }

        private static void ReturnTransaction(string transaction)
        {
            Console.WriteLine();
            Console.WriteLine("Success! Transaction: " + transaction);
            Console.ReadKey();
        }
    }
}
