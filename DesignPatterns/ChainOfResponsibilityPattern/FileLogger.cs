using System;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            _level = level;
        }

        //Override
        protected override void Write(string message)
        {
            Console.WriteLine("File Console::Logger: " + message + Environment.NewLine);
        }
    }
}
