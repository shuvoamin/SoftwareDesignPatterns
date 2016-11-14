namespace DesignPatterns.NullObjectPattern
{
    public abstract class AbstractCustomer
    {
        protected string Name;

        public abstract bool IsNill();
        public abstract string GetName();
    }
}
