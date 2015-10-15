using System;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            _level = level;
        }

        //Override
        protected override void Write(string message)
        {
            Console.WriteLine("Error Console::Logger: " + message + Environment.NewLine);
        }
    }
}
