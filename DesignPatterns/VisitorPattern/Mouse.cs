using DesignPatterns.Interfaces;

namespace DesignPatterns.VisitorPattern
{
    public class Mouse : IComputerPart
    {
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
        //OVerride
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
