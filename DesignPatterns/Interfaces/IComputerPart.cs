namespace DesignPatterns.Interfaces
{
    public interface IComputerPart
    {    
        void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
