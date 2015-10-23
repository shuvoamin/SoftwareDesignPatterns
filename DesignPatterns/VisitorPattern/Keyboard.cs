using DesignPatterns.Interfaces;

namespace DesignPatterns.VisitorPattern
{
    public class Keyboard : IComputerPart
    {
        public IComputerPart ComputerPart
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        //Override
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
