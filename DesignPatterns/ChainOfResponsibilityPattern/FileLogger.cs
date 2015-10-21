using System;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            Level = level;
        }

        //Override
        protected override void Write(string message)
        {
            Console.WriteLine("File Console::Logger: " + message + Environment.NewLine);
        }
    }
}
