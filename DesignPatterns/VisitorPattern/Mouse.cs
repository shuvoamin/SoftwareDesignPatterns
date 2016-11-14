using DesignPatterns.Interfaces;

namespace DesignPatterns.VisitorPattern
{
    public class Mouse : IComputerPart
    {
        public IComputerPart ComputerPart
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        //OVerride
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
