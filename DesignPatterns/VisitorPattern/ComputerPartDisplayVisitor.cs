using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.VisitorPattern
{
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public IComputerPartVisitor ComputerPartVisitor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public void Visit(Computer computer)
        {
            Trace.WriteLine("Displaying Computer" + Environment.NewLine);
        }

        //Override
        public void Visit(Mouse mouse)
        {
            Trace.WriteLine("Displaying Mouse" + Environment.NewLine);
        }

        //Override
        public void Visit(Keyboard keyboard)
        {
            Trace.WriteLine("Displaying Keyboard" + Environment.NewLine);
        }

        //Override
        public void Visit(Monitor monitor)
        {
            Trace.WriteLine("Displaying Monitor" + Environment.NewLine);
        }
    }
}
