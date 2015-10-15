namespace DesignPatterns.Interfaces
{
    public interface IItem
    {
        string name();
        IPacking packing();
        float price();
    }
}
