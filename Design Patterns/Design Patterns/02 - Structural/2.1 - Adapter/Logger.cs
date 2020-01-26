using System;

namespace DesignPatterns.Adapter
{
    // Target class
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Standard log - " + message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("Standard log - " + exception.Message);
        }
    }
}