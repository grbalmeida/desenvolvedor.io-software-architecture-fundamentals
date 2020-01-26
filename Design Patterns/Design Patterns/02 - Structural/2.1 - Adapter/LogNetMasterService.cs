using System;

namespace DesignPatterns.Adapter
{
    // Adaptee class
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Custom log - " + message);
        }
        
        public void LogException(Exception exception)
        {
            Console.WriteLine("Custom log - " + exception.Message);
        }
    }
}