using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
using DesignPatterns.Command;
using DesignPatterns.Composite;
using DesignPatterns.Facade;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Observer;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;
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
            Console.WriteLine("7 - Command");
            Console.WriteLine("8 - Strategy");
            Console.WriteLine("9 - Observer");
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
                case '7':
                    CommandExecution.Execute();
                    break;
                case '8':
                    StrategyExecution.Execute();
                    break;
                case '9':
                    ObserverExecution.Execute();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}