using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
