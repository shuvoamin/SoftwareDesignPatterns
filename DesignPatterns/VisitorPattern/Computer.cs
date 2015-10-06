using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern
{
    public class Computer : IComputerPart
    {
        IComputerPart[] _parts;

        public Computer()
        {
            _parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public DesignPatterns.Interfaces.IComputerPart IComputerPart
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
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < _parts.Length; i++)
            {
                _parts[i].Accept(computerPartVisitor);
            }

            computerPartVisitor.Visit(this);
        }
    }
}
