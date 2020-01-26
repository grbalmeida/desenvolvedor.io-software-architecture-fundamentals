using System;

namespace DesignPatterns.Command
{
    internal class CalculatorCommand : Commander
    {
        private char _operator;
        private int _value;
        private readonly Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char mathOperator, int value)
        {
            _calculator = calculator;
            _operator = mathOperator;
            _value = value;
        }

        public char Operator
        {
            set => _operator = value;
        }

        public int Operand
        {
            set => _value = value;
        }

        public override void Run()
        {
            _calculator.Operation(_operator, _value);
        }

        public override void Undo()
        {
            _calculator.Operation(Undo(_operator), _value);
        }

        private static char Undo(char mathOperator)
        {
            switch (mathOperator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Unknown operator");
            }
        }
    }
}