using DesignPatterns.Interfaces;

namespace DesignPatterns.VisitorPattern
{
    public class Computer : IComputerPart
    {
        IComputerPart[] _parts;

        public Computer()
        {
            _parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public IComputerPart IComputerPart
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
            for (var i = 0; i < _parts.Length; i++)
            {
                _parts[i].Accept(computerPartVisitor);
            }

            computerPartVisitor.Visit(this);
        }
    }
}
