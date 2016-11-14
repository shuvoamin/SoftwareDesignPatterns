namespace DesignPatterns.NullObjectPattern
{
    public class NullCustomer : AbstractCustomer
    {
        //Override
        public override string GetName()
        {
            return "Not Avilable in Customer Database";
        }

        //Overide
        public override bool IsNill()
        {
            return true;
        }
    }
}
