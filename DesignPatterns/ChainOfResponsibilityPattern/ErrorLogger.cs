using System;
using System.Diagnostics;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            Level = level;
        }

        //Override
        protected override void Write(string message)
        {
            Trace.WriteLine("Error Console::Logger: " + message + Environment.NewLine);
        }
    }
}
