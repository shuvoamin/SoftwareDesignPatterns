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
            set
            {
            }
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
    
        public static void Output()
        {
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}
