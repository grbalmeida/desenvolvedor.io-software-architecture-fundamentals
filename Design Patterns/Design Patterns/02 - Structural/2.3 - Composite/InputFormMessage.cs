using System;

namespace DesignPatterns.Composite
{
    public class InputFormMessage : IMessage
    {
        public string Name { get; set; }

        public InputFormMessage(string name)
        {
            Name = name;
        }

        public void DisplayMessages(int sub)
        {
            Console.WriteLine(new string('-', sub) + Name);
        }
    }
}