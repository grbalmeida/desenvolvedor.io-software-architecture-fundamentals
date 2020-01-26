using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
using DesignPatterns.Composite;
using DesignPatterns.Facade;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Singleton;
using System;

namespace DesignPatterns
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Choose the operation:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Factory Method");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("6 - Composite");
            Console.WriteLine("------------------------");

            var option = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            switch (option.KeyChar)
            {
                case '1':
                    AbstractFactoryExecution.Execute();
                    break;
                case '2':
                    FactoryMethodExecution.Execute();
                    break;
                case '3':
                    SingletonExecution.Execute();
                    break;
                case '4':
                    AdapterExecution.Execute();
                    break;
                case '5':
                    FacadeExecution.Execute();
                    break;
                case '6':
                    CompositeExecution.Execute();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}