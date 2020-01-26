using System;

namespace DesignPatterns.Composite
{
    public class DomainMessage : IMessage
    {
        public string Name { get; set; }

        public DomainMessage(string name)
        {
            Name = name;
        }

        public void DisplayMessages(int sub)
        {
            Console.WriteLine(new string('-', sub) + Name);
        }
    }
}