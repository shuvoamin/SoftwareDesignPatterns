using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern
{
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public DesignPatterns.Interfaces.IComputerPartVisitor IComputerPartVisitor
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
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
