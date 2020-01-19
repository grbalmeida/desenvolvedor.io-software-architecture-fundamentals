using SOLID.OCP.Solution.ExtensionMethods;
using System;

namespace SOLID
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Choose the operation");
            Console.WriteLine("1 - OCP");

            var option = Console.ReadKey();

            switch (option.KeyChar)
            {
                case '1':
                    ATM.Operations();
                    break;
            }
        }
    }
}
