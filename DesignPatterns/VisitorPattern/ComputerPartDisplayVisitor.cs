using DesignPatterns.Interfaces;
using System;

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
            Console.WriteLine("Displaying Computer" + Environment.NewLine);
        }

        //Override
        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Displaying Mouse" + Environment.NewLine);
        }

        //Override
        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying Keyboard" + Environment.NewLine);
        }

        //Override
        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Displaying Monitor" + Environment.NewLine);
        }
    }
}
