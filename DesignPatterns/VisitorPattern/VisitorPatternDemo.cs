using DesignPatterns.Interfaces;

namespace DesignPatterns.VisitorPattern
{
    public class VisitorPatternDemo
    {
        public ComputerPartDisplayVisitor ComputerPartDisplayVisitor
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public IComputerPart ComputerPart
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    
        public static void Output()
        {
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}
