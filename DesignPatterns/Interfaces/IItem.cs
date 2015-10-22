namespace DesignPatterns.Interfaces
{
    public interface IItem
    {
        string Name();
        IPacking Packing();
        float Price();
    }
}
