using System;

namespace OOP
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose the operation:");
            Console.WriteLine("");
            Console.WriteLine("1 - Encapsulation");
            Console.WriteLine("2 - Inheritance Composition 1");
            Console.WriteLine("3 - Inheritance Composition 2");
            Console.WriteLine("4 - Interface Implementation");

            var option = Console.ReadKey();

            switch (option.KeyChar)
            {
                case '1':
                    new CoffeeAutomation().ServeCoffee();
                    break;
                case '2':
                    new InheritanceCompositionTests();
                    break;
                case '3':
                    new InheritanceCompositionTests2();
                    break;
                case '4':
                    new InterfaceImplementationTest();
                    break;
            }

            Main();
        }
    }
}
