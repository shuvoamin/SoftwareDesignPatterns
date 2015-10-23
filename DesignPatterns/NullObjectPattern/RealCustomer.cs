namespace DesignPatterns.NullObjectPattern
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            Name = name;
        }

        //Override
        public override bool IsNill()
        {
            return false;
        }

        //Override
        public override string GetName()
        {
            return Name;
        }
    }
}
