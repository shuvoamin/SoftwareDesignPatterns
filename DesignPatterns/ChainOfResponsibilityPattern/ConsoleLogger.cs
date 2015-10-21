using System;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            Level = level;
        }

        //Override
        protected override void Write(string message)
        {
            Console.WriteLine("Standard Console::Logger " + message + Environment.NewLine);
        }
    }
}
