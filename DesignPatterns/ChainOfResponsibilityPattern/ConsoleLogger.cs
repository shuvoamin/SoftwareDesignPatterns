using System;
using System.Diagnostics;

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
            Trace.WriteLine("Standard Console::Logger " + message + Environment.NewLine);
        }
    }
}
