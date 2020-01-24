using System;

namespace DesignPatterns.FactoryMethod
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executing command: " + command);
        }

        public void Open()
        {
            Opened = true;
            Console.WriteLine("Open connection");
        }

        public void Close()
        {
            Console.WriteLine("Connection closed");
        }
    }
}