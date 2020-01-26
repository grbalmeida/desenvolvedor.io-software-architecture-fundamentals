using System;

namespace DesignPatterns.Command
{
    internal class Calculator
    {
        private int _currentValue;

        public void Operation(char mathOperator, int value)
        {
            switch (mathOperator)
            {
                case '+': _currentValue += value; break;
                case '-': _currentValue -= value; break;
                case '*': _currentValue *= value; break;
                case '/': _currentValue /= value; break;
            }

            Console.WriteLine("({1} {2}) - Current value = {0,3}", _currentValue, mathOperator, value);
        }
    }
}