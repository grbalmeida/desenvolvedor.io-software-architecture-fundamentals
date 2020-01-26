﻿using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
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
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
