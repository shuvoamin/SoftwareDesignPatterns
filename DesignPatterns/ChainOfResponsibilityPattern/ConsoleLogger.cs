using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibilityPattern
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            _level = level;
        }

        //Override
        protected override void Write(string message)
        {
            Console.WriteLine("Standard Console::Logger " + message + Environment.NewLine);
        }
    }
}
