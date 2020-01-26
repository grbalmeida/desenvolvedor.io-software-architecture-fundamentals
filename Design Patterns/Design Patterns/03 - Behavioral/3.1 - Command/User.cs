using System;
using System.Collections.Generic;

namespace DesignPatterns.Command
{
    public class User
    {
        // Initializers
        private readonly Calculator _calculator = new Calculator();
        private readonly List<Commander> _commands = new List<Commander>();
        private int _total;

        public void Add(char mathOperator, int value)
        {
            Commander command = new CalculatorCommand(_calculator, mathOperator, value);
            command.Run();

            _commands.Add(command);
            _total++;
        }

        public void TurnBack(int levels)
        {
            Console.WriteLine("\n---- Returning {0} levels ", levels);

            for (var i = 0; i < levels; i++)
            {
                if (_total >= _commands.Count - 1) continue;
                var command = _commands[_total++];
                command.Run();
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undoing {0} levels ", levels);

            for (var i = 0; i < levels; i++)
            {
                if (_total <= 0) continue;
                var command = _commands[--_total];
                command.Undo();
            }
        }
    }
}