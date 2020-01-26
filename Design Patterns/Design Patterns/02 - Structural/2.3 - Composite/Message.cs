using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Composite
{
    public class Message : IMessage, IEnumerable<IMessage>
    {
        private readonly List<IMessage> _list = new List<IMessage>();

        public string Name { get; set; }

        public Message(string name)
        {
            Name = name;
        }

        public void AddChild(IMessage child)
        {
            _list.Add(child);
        }

        public void RemoveChild(IMessage child)
        {
            _list.Remove(child);
        }

        public IMessage GetChild(int index)
        {
            return _list[index];
        }

        public IMessage GetChild(string name)
        {
            return _list.First(m => m.Name == name);
        }
        
        public IEnumerable<IMessage> GetList()
        {
            return _list;
        }

        public IEnumerator<IMessage> GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_list).GetEnumerator();
        }

        public void DisplayMessages(int sub)
        {
            Console.WriteLine(new string('-', sub) + Name);

            foreach (var message in _list)
            {
                message.DisplayMessages(sub + 2);
            }
        }
    }
}